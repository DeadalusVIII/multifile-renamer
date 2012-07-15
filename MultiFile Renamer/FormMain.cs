using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace MultiFile_Renamer
{
    public struct DefaultProperties
    {
        int _top;
        int _left;
        int _width;
        int _height;

        public void SaveDefaultProperties(Control ob)
        {
            _top = ob.Top;
            _left = ob.Left;
            _width = ob.Width;
            _height = ob.Height;
        }

        public void LoadDefaultProperties(Control ob)
        {
            ob.Top = _top;
            ob.Left = _left;
            ob.Width = _width;
            ob.Height = _height;
        }
    }

    public partial class FormMain : Form
    {        
        const String                    SaveFileName = "Definitions.mfr";
        const String                    RegistryKeyName = "Software\\MultiFileRenamer";
        String                          _currentPath = "";
        public String[]                 imageExtensions = { "bmp", "jpeg", "jpg", "png", "gif", "wmf" };
        public String[]                 mediaExtensions = { "avi", "mp3", "wav" };
        String[]                        _filterExtensions = { "" };
        public String                   defaultSeparator = " - ";
        public int                      numberLocation = 3;
        //FormSettings                    _formSettings;
        public int                      savingMode = 3;
        FormProgress                    _formProgress;

        DefaultProperties               _defGroupPreview, _defPictureBoxPreview;

        public FormMain()
        {
            InitializeComponent();

            //Centra a janela no écrã
            CenterToScreen();

            //altera a indentação na janela de pastas
            treeViewFolder.Indent = 15;

            //guarda os dados 
            _defGroupPreview.SaveDefaultProperties(groupPreview);
            _defPictureBoxPreview.SaveDefaultProperties(pictureBoxPreview);
            
            //carrega as definições
            LoadDefinitions();
        }

        public FormMain(String path) : this()
        {
            //loadPath(path);
            _currentPath = path;
        }

        private void MenuItemExitClick(object sender, EventArgs e)
        {
            Application.Exit();           
        }

        private void RefreshDriveList()
        {
            //elimina todos os nós debaixo de "My Active Drives"
            treeViewFolder.Nodes[0].Nodes.Clear();

            //vai buscar os nomes de todas as drives activas
            String[] drives = Directory.GetLogicalDrives();

            //para cada uma dessas drives
            foreach (String drive in drives)
            {
                //para saber qual o ícone a utilizar, é necessário saber o tipo de drive
                DriveInfo driveInfo = new DriveInfo(drive);

                if (driveInfo.IsReady)
                {
                    //adiciona à treeview
                    TreeNode node = treeViewFolder.Nodes[0].Nodes.Add(drive);
                    
                    if (driveInfo.DriveType == DriveType.Removable)
                    {
                        node.ImageIndex = 1;
                    }
                    else if (driveInfo.DriveType == DriveType.Fixed)
                    {
                        node.ImageIndex = 2;
                    }
                    else if (driveInfo.DriveType == DriveType.CDRom)
                    {
                        node.ImageIndex = 3;
                    }
                    else if (driveInfo.DriveType == DriveType.Network)
                    {
                        node.ImageIndex = 4;
                    }

                    //node.Text = drive + driveInfo.VolumeLabel;
                }
            }
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            //actualiza a lista de drives prontas
            RefreshDriveList();
            
            //carrega o caminho gravado em ficheiro
            LoadPath(_currentPath);
        }

        private void ShowSubFolders(TreeNode node)
        {
            if (node.Text != "My Active Drives")
            {
                //busca o caminho completo para a pasta
                _currentPath = getFullPath(node);

                //busca informação sobre a pasta
                DirectoryInfo dir = new DirectoryInfo(_currentPath);

                //para depois obter a lista com os subdirectórios
                DirectoryInfo[] subDirs = dir.GetDirectories();

                //apaga a lista de nós filhos que tinha (para não acumular)
                node.Nodes.Clear();

                //mostra a lista de subdirectórios
                foreach (DirectoryInfo subDir in subDirs)
                {
                    //para que não aceda a directórios de systema ou ocultos
                    if ((subDir.Attributes & FileAttributes.Hidden) == 0 && (subDir.Attributes & FileAttributes.System) == 0)
                    {
                        TreeNode childNode = node.Nodes.Add(subDir.Name);
                        childNode.ImageIndex = 6;
                    }
                }

                //adiciona ficheiros à lista, tendo em conta o filtro
                RefreshListFolderFiles();
            }
            else
                _currentPath = "";
        }

        private void RefreshListFolderFiles()
        {
            //busca informação sobre a pasta
            DirectoryInfo dir = new DirectoryInfo(_currentPath);

            //apaga a lista de ficheiros que tinha (para não acumular)
            listViewFilesInFolder.Items.Clear();

            //mostra os ficheiros dentro da pasta
            FileInfo[] files = dir.GetFiles();

            //mostra a lista de ficheiros
            foreach (FileInfo file in files)
            {
                //para que não aceda a directórios de systema ou ocultos
                if ((file.Attributes & FileAttributes.Hidden) == 0 && (file.Attributes & FileAttributes.System) == 0)
                {
                    MultiFileViewItem item = new MultiFileViewItem(file.Name, _currentPath, file.CreationTime.ToString());

                    if (_filterExtensions[0] != "")
                    {
                        foreach (String extension in _filterExtensions)
                        {
                            if (item.GetExtension() == extension.ToLower())
                            {
                                listViewFilesInFolder.Items.Add(item).SubItems.Add(item.CreationTime);
                                break;
                            }
                        }
                    }
                    else
                        listViewFilesInFolder.Items.Add(item).SubItems.Add(item.CreationTime);    
                }
            }            
        }

        private void TreeViewFolderAfterSelect(object sender, TreeViewEventArgs e)
        {            
            ShowSubFolders(treeViewFolder.SelectedNode);

            if (_currentPath == "")
                treeViewFolder.SelectedImageIndex = 0;
            else if (IsRootDrive(_currentPath))
                treeViewFolder.SelectedImageIndex = 2;
            else
                treeViewFolder.SelectedImageIndex = 5;
        }

        /**
         * Verifica se uma string com um endereço contém apenas a designação da drive,
         * como por exemplo: "C:\" ou "F:\"
         */
        public static bool IsRootDrive(String str)
        {
            if (str.Length == 3 && str[1] == ':' && str[2] == '\\')
                return true;
            
            return false;
        }

        /**
         * Percorre todos os nós pai para obter o caminho completo da pasta.
         */
        private String getFullPath(TreeNode node)
        {
            String newpath = node.Text;
                        
            while (!IsRootDrive(node.Text))
            {
                node = node.Parent;
                if(IsRootDrive(node.Text))
                    newpath = node.Text + newpath;
                else
                    newpath = node.Text + "\\" + newpath;
            }

            return newpath;
        }

        /**
         * Reage à selecção de ficheiro, mostrando a imagem na zona de preview
         */
        private void ListViewFilesInFolderSelectedIndexChanged(object sender, EventArgs e)
        {
            PreviewImageMedia();
        }

        private void PreviewImageMedia()
        {
            bool bIsImage = false, bIsMedia = false;

            if (listViewFilesInFolder.SelectedItems.Count > 0)
            {
                MultiFileViewItem item = ((MultiFileViewItem)listViewFilesInFolder.SelectedItems[0]);

                //verifica se é uma imagem
                foreach (String ext in imageExtensions)
                    if (ext.ToLower() == item.GetExtension())
                    {
                        pictureBoxPreview.ImageLocation = item.GetFullPath();
                        bIsImage = true;
                        break;
                    }

                //se não for imagem
                if (!bIsImage)
                {
                    pictureBoxPreview.ImageLocation = "";

                    //verifica se é um filme
                    foreach (String ext in mediaExtensions)
                        if (ext.ToLower() == item.GetExtension())
                        {
                            windowsMediaPlayer.URL = item.GetFullPath();
                            bIsMedia = true;
                            break;
                        }
                }

                if (bIsMedia)
                    windowsMediaPlayer.Visible = true;
                else
                {
                    windowsMediaPlayer.Visible = false;
                    windowsMediaPlayer.URL = "";
                }
            }
            else
            {
                pictureBoxPreview.ImageLocation = "";
                windowsMediaPlayer.Visible = false;
                windowsMediaPlayer.URL = "";
            }
        }

        /**
         * Retorna o tamanho da pictureBox quando o rato sai
        */
        private void PictureBoxPreviewMouseLeave(object sender, EventArgs e)
        {
            _defPictureBoxPreview.LoadDefaultProperties(pictureBoxPreview);
            _defGroupPreview.LoadDefaultProperties(groupPreview);
        }

        /**
         * Aumenta a imagem quando o rato entra na pictureBox
         */
        private void PictureBoxPreviewMouseEnter(object sender, EventArgs e)
        {
            float relation;

            //se houver uma imagem a ser mostrada
            if (pictureBoxPreview.ImageLocation != "")
            {
                //portrait ou quadrada
                if (pictureBoxPreview.Image.Height >= pictureBoxPreview.Image.Width)
                {
                    relation = pictureBoxPreview.Image.Width / (float)pictureBoxPreview.Image.Height;

                    groupPreview.Top = 50;
                    groupPreview.Height = 500;
                    groupPreview.Width = (int)(relation * groupPreview.Height);
                    groupPreview.Left = 400 - (groupPreview.Width / 2);

                    pictureBoxPreview.Height = groupPreview.Height - 30;
                    pictureBoxPreview.Width = groupPreview.Width - 10;
                }
                //landscape
                else if (pictureBoxPreview.Image.Height < pictureBoxPreview.Image.Width)
                {
                    relation = pictureBoxPreview.Image.Height / (float)pictureBoxPreview.Image.Width;

                    groupPreview.Left = 100;
                    groupPreview.Width = 600;
                    groupPreview.Height = (int)(relation * groupPreview.Width);
                    groupPreview.Top = 300 - (groupPreview.Height / 2);

                    pictureBoxPreview.Height = groupPreview.Height - 30;
                    pictureBoxPreview.Width = groupPreview.Width - 10;

                }
            }
        }

        /**
         * Devolve a extensão de um ficheiro
         */
        public String GetExtension(String text)
        {            
            return text.Substring(text.LastIndexOf('.') + 1).ToLower();
        }

        /**
         * Move um item de uma lista para a outra
         */ 
        private void MoveFiles(ListView origin, ListView destiny, MultiFileViewItem item)
        {
            //remove o item da lista de origem
            origin.Items.Remove(item);

            //acrescenta à lista de destino para renomear
            destiny.Items.Add(item);

            PreviewImageMedia();
        } 

        private void ButtonListOneClick(object sender, EventArgs e)
        {
            foreach (MultiFileViewItem item in listViewFilesInFolder.SelectedItems)
            {
                //acrescenta à lista de ficheiros para renomear e retira da lista de ficheiros
                MoveFiles(listViewFilesInFolder, listViewFilesToRename, item);
            }         
        }

        private void ButtonListAllClick(object sender, EventArgs e)
        {
            foreach(MultiFileViewItem item in listViewFilesInFolder.Items)
            {
                //acrescenta à lista de ficheiros para renomear e retira da lista de ficheiros
                MoveFiles(listViewFilesInFolder, listViewFilesToRename, item);
            }

            VerifyDigitNumber();
        }

        private void ListViewFilesInFolderDoubleClick(object sender, EventArgs e)
        {
            foreach (MultiFileViewItem item in listViewFilesInFolder.SelectedItems)
            {
                //acrescenta à lista de ficheiros para renomear e retira da lista de ficheiros
                MoveFiles(listViewFilesInFolder, listViewFilesToRename, item);
            }

            VerifyDigitNumber();
        }

        private void ButtonRemoveOneClick(object sender, EventArgs e)
        {
            foreach (MultiFileViewItem item in listViewFilesToRename.SelectedItems)
            {
                //acrescenta à lista de ficheiros para renomear e retira da lista de ficheiros
                MoveFiles(listViewFilesToRename, listViewFilesInFolder, item);
            }

            VerifyDigitNumber();
        }

        private void ButtonRemoveAllClick(object sender, EventArgs e)
        {
            foreach (MultiFileViewItem item in listViewFilesToRename.Items)
            {
                //acrescenta à lista de ficheiros para renomear e retira da lista de ficheiros
                MoveFiles(listViewFilesToRename, listViewFilesInFolder, item);
            }

            VerifyDigitNumber();
        }

        private void ListViewFilesToRenameDoubleClick(object sender, EventArgs e)
        {
            foreach (MultiFileViewItem item in listViewFilesToRename.SelectedItems)
            {
                //acrescenta à lista de ficheiros para renomear e retira da lista de ficheiros
                MoveFiles(listViewFilesToRename, listViewFilesInFolder, item);                
            }

            VerifyDigitNumber();
        }

        /**
         * Verifica se o numero de dígitos intrduzido é suficiente para numerar toda a lista, 
         * partindo do valor inicial
         */
        private void VerifyDigitNumber()
        {
            //determina o número máximo que o contador pode alcançar
            int maxNumber = Convert.ToInt32(textBoxStartingN.Text) + listViewFilesToRename.Items.Count;

            //vê o numero de digitos necessários
            int digitsNecessary = Convert.ToInt32(maxNumber.ToString().Length);

            //
            if (Convert.ToInt32(textBoxDigitN.Text) < digitsNecessary)
                textBoxDigitN.Text = digitsNecessary.ToString();
        }
        
        private void TextBoxExtensionsTextChanged(object sender, EventArgs e)
        {
            _filterExtensions = textBoxExtensions.Text.Split(',');

            if (_currentPath != "")
            {
                RefreshListFolderFiles();
            }
        }

        /**Verifica se o conteúdo de uma string é um valor numérico
         */
        private bool isNumber(String text)
        {
            for(int i=0; i<text.Length;i++)
            {
                //equivalente a isDigit
                if(text[i] < 48 || text[i] > 57)
                    return false;
            }

            return true;
        }

        /**
         * Actualiza o texto de exemplo de nome de ficheiro
         */
        private void RefreshTextExample(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = RemoveInvalidCharacters(((TextBox)sender).Text);            

            RefreshTextExample();
        }

        public static String RemoveInvalidCharacters(String text)
        {
            String newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '\\' && text[i] != '/' &&
                        text[i] != ':' && text[i] != '?' &&
                                text[i] != '\"' && text[i] != '<' &&
                                    text[i] != '>' && text[i] != '|')
                    newText += text[i];
            }
            return newText;
        }

        public void RefreshTextExample()
        {
            String stringNumber = "";
            int digits;

            //não deixar colocar caracteres inválidos na caixa ou nada, põe o valor 0
            if (!isNumber(textBoxStartingN.Text) || textBoxStartingN.Text.Length < 1)
                textBoxStartingN.Text = "0";
            else
            {
                //retira os zeros no inicio da string, pois não acrescentam nada
                if (textBoxStartingN.Text[0] == '0')
                {
                    textBoxStartingN.Text = (Convert.ToInt32(textBoxStartingN.Text)).ToString();
                }
            }

            //não deixar colocar caracteres inválidos na caixa ou valores menores que o número de dígitos 
            //do valor inicial 
            if (!isNumber(textBoxDigitN.Text) || textBoxDigitN.Text.Length < 1)
                textBoxDigitN.Text = textBoxStartingN.Text.Length.ToString();

            digits = Convert.ToInt32(textBoxDigitN.Text);
            if (digits < textBoxStartingN.Text.Length)
            {
                digits = textBoxStartingN.Text.Length;
                textBoxDigitN.Text = digits.ToString();
            }

            VerifyDigitNumber();

            //coloca 'digits' zeros à frente do número
            for (int i = 0; i < digits - textBoxStartingN.Text.Length; i++)
                stringNumber += "0";

            stringNumber += textBoxStartingN.Text;

            labelExample.Text = FileNewName(stringNumber, "ext");
        }
        
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = RemoveInvalidCharacters(((TextBox)sender).Text);
        }

        /**
         * Devolve o nome do ficheiro, com base no valor de série e a sua colocação
         * no nome do ficheiro, não esquecendo a sua extensão  
         */ 
        private String FileNewName(String stringNumber, String extension)
        {
            String newName = "";

            switch (numberLocation)
            {
                //Se o contador aparecer primeiro
                case 1:
                    newName += stringNumber;

                    if (textBoxLabel1.Text != "")
                        newName += defaultSeparator + textBoxLabel1.Text;

                    if (textBoxLabel2.Text != "")
                        newName += defaultSeparator + textBoxLabel2.Text;
                    
                    break;
                //Se o contador aparecer em segundo
                case 2:
                    if (textBoxLabel1.Text != "")
                        newName += textBoxLabel1.Text + defaultSeparator;

                    newName += stringNumber;

                    if (textBoxLabel2.Text != "")
                        newName += defaultSeparator + textBoxLabel2.Text;

                    break;
                //Se o contador aparecer em último
                case 3:
                    if (textBoxLabel1.Text != "")
                        newName += textBoxLabel1.Text + defaultSeparator;

                    if (textBoxLabel2.Text != "")
                        newName += textBoxLabel2.Text + defaultSeparator;

                    newName += stringNumber;

                    break;
            }

            return newName += "." + extension;
        }

        private void MenuItemSettingsClick(object sender, EventArgs e)
        {
            //cria uma instância da janela de Settings e mostra
            new FormSettings(this).ShowDialog();
        }

        private void MenuItemAboutClick(object sender, EventArgs e)
        {
            //cria uma instância da janela de About e mostra
            new FormAbout().ShowDialog();
        }

        //ao fechar, grava ou não os dados
        private void FormMainFormClosing(object sender, FormClosingEventArgs e)
        {            
            SaveDefinitions();
        }

        private void LoadDefinitions()
        {
            //se existir um ficheiro de definições, lê daí
            if (File.Exists(SaveFileName))
            {
                //o modo de gravação nem precisa de ser lido
                savingMode = 1;

                FileStream fileStr = File.OpenRead(SaveFileName);
                BinaryReader br = new BinaryReader(fileStr);

                //lê o caminho da pasta actual
                _currentPath = br.ReadString();

                //lê o separador
                defaultSeparator = br.ReadString();

                //lê as extensões de ficheiros de imagem                
                imageExtensions = br.ReadString().Split(',');
                
                //lê as extensões de ficheiros de media
                mediaExtensions = br.ReadString().Split(',');

                //lê a posição do identificador numérico
                numberLocation = br.ReadInt32();

                //lê as extensões de ficheiros a filtrar                
                textBoxExtensions.Text = br.ReadString();
                _filterExtensions = textBoxExtensions.Text.Split(',');               

                br.Close();
                fileStr.Close(); 
            }
            else
            {
                //tenta abrir a chave 
                RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyName);

                //se existir uma chave no registo disto, lê daí
                if (key != null)
                {
                    //o modo de gravação nem precisa de ser lido
                    savingMode = 2;

                    //lê o caminho da pasta actual
                    _currentPath = (String)key.GetValue("currentPath");

                    //lê o separador
                    defaultSeparator = (String)key.GetValue("defaultSeparator");

                    //lê as extensões de ficheiros de imagem                
                    imageExtensions = ((String)key.GetValue("imageExtensions")).Split(',');

                    //lê as extensões de ficheiros de media
                    mediaExtensions = ((String)key.GetValue("mediaExtensions")).Split(',');
                    

                    //lê a posição do identificador numérico
                    numberLocation = (Int32)key.GetValue("numberLocation");

                    //lê as extensões de ficheiros a filtrar                
                    textBoxExtensions.Text = (String)key.GetValue("filterExtensions");
                    _filterExtensions = textBoxExtensions.Text.Split(',');      

                }
                //caso contrário, a opção escolhida era "não gravar", logo as definições são as por defeito                
            }
        }
        
        private void LoadPath(String path)
        {
            //ignora caso, por alguma razão, aparecer um ficheiro vazio
            if (String.IsNullOrEmpty(path))
                return;

            String drive = path.Substring(0, 3);
            String[] subFolders = path.Substring(3).Split('\\');
            TreeNode currNode = null;

            //expande o "My Active Drives"
            treeViewFolder.Nodes[0].ExpandAll();

            //expande a drive
            foreach (TreeNode tn in treeViewFolder.Nodes[0].Nodes)
            {
                if (tn.Text == drive)
                {
                    ShowSubFolders(tn);
                    tn.ExpandAll();
                    currNode = tn;
                    treeViewFolder.SelectedNode = tn;
                    break;
                }
            }
            //se não encontrou a drive, não faz mais nada
            if (currNode == null)
                return;

            foreach (String subFolder in subFolders)
            {
                foreach (TreeNode tn in currNode.Nodes)
                {
                    if (tn.Text == subFolder)
                    {
                        ShowSubFolders(tn);
                        tn.ExpandAll();
                        currNode = tn;
                        treeViewFolder.SelectedNode = tn;
                        break;
                    }
                }
            }
        }

        private void SaveDefinitions()
        {
            String temp;

            switch (savingMode)
            {
                //grava os dados num ficheiro de texto
                case 1:
                    FileStream fileStr = File.Create(SaveFileName);
                    BinaryWriter bw = new BinaryWriter(fileStr); 
                    
                    //grava o caminho da pasta actual
                    bw.Write(_currentPath); 

                    //grava o separador
                    bw.Write(defaultSeparator);
 
                    //grava as extensões de ficheiros de imagem
                    temp = imageExtensions[0];
                    for (int i = 1; i < imageExtensions.Length;i++)
                        temp += "," + imageExtensions[i];

                    bw.Write(temp);

                    //grava as extensões de ficheiros de media
                    temp = mediaExtensions[0];
                    for (int i = 1; i < mediaExtensions.Length;i++)
                        temp += "," + mediaExtensions[i];
                    
                    bw.Write(temp);

                    //grava a posição do identificador numérico
                    bw.Write(numberLocation);

                    //grava as extensões de ficheiros a filtrar
                    temp = _filterExtensions[0];
                    for (int i = 1; i < _filterExtensions.Length; i++)
                        temp += "," + _filterExtensions[i];

                    bw.Write(temp);

                    //fecha o stram
                    bw.Close();
                    fileStr.Close();

                    //apaga a chave                    
                    if(Registry.CurrentUser.OpenSubKey(RegistryKeyName, false ) != null)
                        Registry.CurrentUser.DeleteSubKey(RegistryKeyName);

                    break;
                //grava os dados no registo do windows
                case 2:

                    RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyName, true) ?? Registry.CurrentUser.CreateSubKey(RegistryKeyName);

                    //grava o caminho da pasta actual
                    key.SetValue("currentPath", _currentPath);
                    
                    //grava o separador
                    key.SetValue("defaultSeparator", defaultSeparator);
 
                    //grava as extensões de ficheiros de imagem
                    temp = imageExtensions[0];
                    for (int i = 1; i < imageExtensions.Length;i++)
                        temp += "," + imageExtensions[i];

                    key.SetValue("imageExtensions", temp);

                    //grava as extensões de ficheiros de media
                    temp = mediaExtensions[0];
                    for (int i = 1; i < mediaExtensions.Length;i++)
                        temp += "," + mediaExtensions[i];
                    
                    key.SetValue("mediaExtensions", temp);

                    //grava a posição do identificador numérico
                    key.SetValue("numberLocation", numberLocation);

                    //grava as extensões de ficheiros a filtrar
                    temp = _filterExtensions[0];
                    for (int i = 1; i < _filterExtensions.Length; i++)
                        temp += "," + _filterExtensions[i];

                    key.SetValue("filterExtensions", temp);

                    if(File.Exists(SaveFileName))
                        File.Delete(SaveFileName);

                    break;
                case 3:
                    //caso contrário não grava e apaga os ficheiros
                    if(Registry.CurrentUser.OpenSubKey(RegistryKeyName, false ) != null)
                        Registry.CurrentUser.DeleteSubKey(RegistryKeyName);

                    if (File.Exists(SaveFileName))
                        File.Delete(SaveFileName);
                    break;                
            }
        }


        /**
         * Handler do botão para fazer a renomeação propriamente dita
         */
        private void ButtonRenameClick(object sender, EventArgs e)
        {
            MultiFileViewItem[] itemCollection = new MultiFileViewItem[listViewFilesToRename.Items.Count];

            listViewFilesToRename.Items.CopyTo(itemCollection,0);

            _formProgress = new FormProgress(backgroundWorkerRename);
            _formProgress.Show();
            
            //desactiva os controlos
            EnableControls(false);

            backgroundWorkerRename.RunWorkerAsync(itemCollection);            
        }
        
        /**
         * Handler do botão que remove caracteres inválidos
         */ 
        private void ButtonReplaceClick(object sender, EventArgs e)
        {
            if(textBoxStringReplace.Text == "")
                return;

            MultiFileViewItem[] itemCollection = new MultiFileViewItem[listViewFilesToRename.Items.Count];

            listViewFilesToRename.Items.CopyTo(itemCollection, 0);

            _formProgress = new FormProgress(backgroundWorkerReplace);
            _formProgress.Show();

            //desactiva os controlos
            EnableControls(false);

            backgroundWorkerReplace.RunWorkerAsync(itemCollection);
        }
        
        private void ButtonChangeCaseClick(object sender, EventArgs e)
        {
            MultiFileViewItem[] itemCollection = new MultiFileViewItem[listViewFilesToRename.Items.Count];

            listViewFilesToRename.Items.CopyTo(itemCollection,0);

            _formProgress = new FormProgress(backgroundWorkerCase);
            _formProgress.Show();

            //desactiva os controlos
            EnableControls(false);

            backgroundWorkerCase.RunWorkerAsync(itemCollection);
        }
        
        private void BackgroundWorkerRenameDoWork(object sender, DoWorkEventArgs e)
        {
            float percentage = 0;
            float increment = ((100f) / ((MultiFileViewItem[])e.Argument).Length);
            int counter = Convert.ToInt32(textBoxStartingN.Text);

            foreach (MultiFileViewItem item in (MultiFileViewItem[])e.Argument)
            {
                String oldFileName = item.GetFullPath(), stringNumber = "", counterString = counter.ToString();

                int digits = Convert.ToInt32(textBoxDigitN.Text);

                //coloca 'digits' zeros à frente do número
                for (int i = 0; i < digits - counterString.Length; i++)
                    stringNumber += "0";

                //acrescenta a string com o número de série
                stringNumber += counterString;

                String newFileName = item.FolderPath + FileNewName(stringNumber, item.GetExtension());
                if (oldFileName != newFileName)
                {
                    //cria um novo ficheiro com o mesmo nome
                    try
                    {
                        File.Move(oldFileName, newFileName);
                        /*File.Copy(oldFileName, newFileName);

                        //e apagar o antigo
                        File.Delete(oldFileName);*/
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Cannot rename the file " + newFileName + ".\nFile already exists.", "Renaming Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Cannot rename the file " + oldFileName + ".\nFile is protected or in use.", "Renaming Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                counter++;

                percentage += increment;
                backgroundWorkerRename.ReportProgress((int)percentage);

                if (backgroundWorkerRename.CancellationPending)
                    break;
            }
        }

        private void BackgroundWorkerReplaceDoWork(object sender, DoWorkEventArgs e)
        {
            float percentage = 0;
            float increment = ((100f) / ((MultiFileViewItem[])e.Argument).Length);

            foreach (MultiFileViewItem item in (MultiFileViewItem[])e.Argument)
            {
                String oldFileName = item.GetFullPath();
                String temp;

                if (IsRootDrive(item.FolderPath))
                    temp = item.FolderPath + item.GetOriginalName().Replace(textBoxStringReplace.Text, textBoxStringReplacement.Text);
                else
                    temp = item.FolderPath + "\\" + item.GetOriginalName().Replace(textBoxStringReplace.Text, textBoxStringReplacement.Text);

                String newFileName = temp + "." + item.GetExtension();

                if (oldFileName != newFileName)
                {
                    try
                    {
                        File.Move(oldFileName, newFileName);

                        /*File.Copy(oldFileName, newFileName);

                        //e apagar o antigo
                        File.Delete(oldFileName);*/
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Cannot rename the file " + newFileName + ".\nFile already exists.", "Renaming Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Cannot rename the file " + oldFileName + ".\nFile is protected or in use.", "Renaming Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                percentage += increment;
                backgroundWorkerReplace.ReportProgress((int)percentage);

                if (backgroundWorkerReplace.CancellationPending)
                    break;
            }
        }

        private void BackgroundWorkerCaseDoWork(object sender, DoWorkEventArgs e)
        {
            float percentage=0;
            float increment = ((100f) / ((MultiFileViewItem[])e.Argument).Length);

            foreach (MultiFileViewItem item in (MultiFileViewItem[])e.Argument)
            {
                String oldFileName = item.GetFullPath();
                String newFileName;

                if (IsRootDrive(item.FolderPath))
                    newFileName = item.FolderPath;
                else
                    newFileName = item.FolderPath + "\\";

                if (radioButtonUpperCase.Checked)
                {
                    newFileName += item.GetOriginalName().ToUpper() + ".";

                    if (checkBoxChangeExtension.Checked)
                        newFileName += item.GetExtension().ToUpper();
                    else
                        newFileName += item.GetExtension();
                }
                else if (radioButtonLowerCase.Checked)
                {
                    newFileName += item.GetOriginalName().ToLower() + ".";

                    if (checkBoxChangeExtension.Checked)
                        newFileName += item.GetExtension().ToLower();
                    else
                        newFileName += item.GetExtension();
                }
                else
                {
                    newFileName += ToTitleCase(item.GetOriginalName());

                    if (checkBoxChangeExtension.Checked)
                        newFileName += ToTitleCase("." + item.GetExtension());
                    else
                        newFileName += "." + item.GetExtension();
                }

                try
                {
                    //cria um novo ficheiro com o mesmo nome
                    /*File.Copy(oldFileName, newFileName + ".temp");

                    //e apagar o antigo
                    File.Delete(oldFileName);

                    File.Copy(newFileName + ".temp", newFileName);

                    File.Delete(newFileName + ".temp");*/

                    File.Move(oldFileName, newFileName + ".temp");

                    File.Move(newFileName + ".temp", newFileName);
                }
                catch (IOException)
                {                    
                    MessageBox.Show("Cannot rename the file " + newFileName + ".\nFile already exists.", "Renaming Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Cannot rename the file " + oldFileName + ".\nFile is protected or in use.", "Renaming Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                percentage+=increment;
                backgroundWorkerCase.ReportProgress((int)percentage);

                if (backgroundWorkerCase.CancellationPending)
                    break;
            }

        }

        private String ToTitleCase(String text)
        {
            char previousChar = '0';
            text = text.ToLower();
            String newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (!isLetter(previousChar)
                    && isLetter(text[i]))
                {
                    char c = (char)(text[i] - 32);
                    newText += c;
                }
                else
                {
                    newText += text[i];
                }

                previousChar = text[i];
            }

            return newText;

        }

        private bool isLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //apaga a lista de ficheiros para renomear
            listViewFilesToRename.Items.Clear();

            //faz refresh à lista de ficheiros da pasta
            RefreshListFolderFiles();

            //fecha a janela de progresso
            _formProgress.Close();

            //activa os controlos
            EnableControls(true);
        }

        private void BackgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _formProgress.setProgressBarValue(e.ProgressPercentage);
        }

        private void EnableControls(bool bLock)        
        {
            foreach (Control c in Controls)            
                c.Enabled = bLock;  
        }

        private void InstallToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                ExplorerIntegrationInstaller.Install();
                MessageBox.Show("MultiFile Renamer was sucessfully added to the Windows Explorer Context Menu.",
                                "Installation successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Installation Failed. " + ex.Message, "Installation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void UninstallToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                ExplorerIntegrationInstaller.Uninstall();
                MessageBox.Show("MultiFile Renamer was sucessfully removed from the Windows Explorer Context Menu.",
                                "Uninstallation successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Uninstallation Failed. " + ex.Message, "Uninstallation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }   
}
