using System;
using System.Windows.Forms;

namespace MultiFile_Renamer
{
    public partial class FormSettings : Form
    {
        private FormMain fMain;
        private int _numberLocation, _savingMode;

        public FormSettings(FormMain form)
        {
            InitializeComponent();

            //Centra a janela no écrã
            CenterToScreen();

            //guarda o apontador para o formulário principal
            fMain = form;

            //carrega os dados actuais da posição do identificador
            _numberLocation = fMain.numberLocation;
            radioButtonLocation1.Checked = false;
            radioButtonLocation2.Checked = false;
            radioButtonLocation3.Checked = false;
            switch (_numberLocation)
            {
                case 1: radioButtonLocation1.Checked = true; break;
                case 2: radioButtonLocation2.Checked = true; break;
                case 3: radioButtonLocation3.Checked = true; break;
            }

            //carrega os separador por defeito
            textBoxSeparator.Text = fMain.defaultSeparator;

            //carrega as definições de gravação
            _savingMode = fMain.savingMode;
            radioButtonSaveLocal.Checked = false;
            radioButtonSaveRegistry.Checked = false;
            radioButtonDontSave.Checked = false;
            switch (_savingMode)
            {
                case 1: radioButtonSaveLocal.Checked = true; break;
                case 2: radioButtonSaveRegistry.Checked = true; break;
                case 3: radioButtonDontSave.Checked = true; break;
            }

            //carrega as extensões de imagem a fazer preview
            textBoxImages.Text = fMain.imageExtensions[0];
            for (int i = 1; i < fMain.imageExtensions.Length;i++)
                textBoxImages.Text += "," + fMain.imageExtensions[i];

            //carrega as extensões de filmes/musica a fazer preview
            textBoxMedia.Text = fMain.mediaExtensions[0];
            for (int i = 1; i < fMain.mediaExtensions.Length; i++)
                textBoxMedia.Text += "," + fMain.mediaExtensions[i];

            RefreshRadioButtons();
        }

        private void ButtonApplyClick(object sender, EventArgs e)
        {
            //grava as definições de gravação
            fMain.savingMode = _savingMode;

            //grava os separador por defeito
            fMain.defaultSeparator = textBoxSeparator.Text;

            //grava as extensões de imagem a fazer preview
            fMain.imageExtensions = textBoxImages.Text.Split(',');

            //grava as extensões de filmes/musica a fazer preview
            fMain.mediaExtensions = textBoxMedia.Text.Split(',');

            //grava as localização do identificador e faz refresh à label
            fMain.numberLocation = _numberLocation;
            fMain.RefreshTextExample();

            //fecha a janela
            Close();
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            //fecha a janela, sem gravar nada
            Close();
        }

        private void RadioButtonLocation1Click(object sender, EventArgs e)
        {
            _numberLocation = 1;
        }

        private void RadioButtonLocation2Click(object sender, EventArgs e)
        {
            _numberLocation = 2;
        }

        private void RadioButtonLocation3Click(object sender, EventArgs e)
        {
            _numberLocation = 3;
        }

        private void TabControl1Click(object sender, EventArgs e)
        {
            _savingMode = 1;
        }

        private void RadioButtonSaveRegistryClick(object sender, EventArgs e)
        {            
            _savingMode = 2;
        }

        private void RadioButtonDontSaveClick(object sender, EventArgs e)
        {
            _savingMode = 3;
        }

        private void RefreshRadioButtons()
        {
            radioButtonLocation1.Text = "00" + textBoxSeparator.Text + "Label1" + textBoxSeparator.Text + "Label2.ext";
            radioButtonLocation2.Text = "Label1" + textBoxSeparator.Text + "00" + textBoxSeparator.Text + "Label2.ext";
            radioButtonLocation3.Text = "Label1" + textBoxSeparator.Text + "Label2" + textBoxSeparator.Text + "00.ext";
        }

        private void TextBoxSeparatorTextChanged(object sender, EventArgs e)
        {
            textBoxSeparator.Text = FormMain.RemoveInvalidCharacters(textBoxSeparator.Text);

            RefreshRadioButtons();
        }

    }
}