namespace SymLink_Generator
{
    using Microsoft.WindowsAPICodePack.Dialogs;

    public partial class Symlink_Generater : Form
    {
        public Symlink_Generater()
        {
            InitializeComponent();
        }


        private void Link_Loc_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(Link_Loc.Text))
            {
                Link_Path_Error.Visible = false;
                Folder_Name.Enabled = true;
                Check_Input();
            }
            else
            {
                Link_Path_Error.Visible = true;
                Folder_Name.Enabled = false;

            }

        }

        private void Link_Loc_button_Click(object sender, EventArgs e)
        {
            var cfd = new CommonOpenFileDialog();
            cfd.IsFolderPicker = true;
            if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Link_Loc.Text = cfd.FileName;
            }
        }

        private void Folder_Name_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(Link_Loc.Text + "\\" + Folder_Name.Text) != true)
            {
                Folder_Exist.Visible = false;
                Check_Input();

            }
            else
            {
                Folder_Exist.Visible = true;

            }

        }

        private void Jump_Loc_TextChanged_1(object sender, EventArgs e)
        {
            if (Directory.Exists(Jump_Loc.Text))
            {
                Path_Error.Visible = false;
                Check_Input();
            }
            else
            {
                Path_Error.Visible = true;

            }
        }

        private void Jump_Loc_button_Click(object sender, EventArgs e)
        {
            var cfd = new CommonOpenFileDialog();
            cfd.IsFolderPicker = true;
            if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Jump_Loc.Text = cfd.FileName;
            }
        }

        private void Check_Input() {
            if (String.IsNullOrEmpty(Link_Loc.Text) == false && String.IsNullOrEmpty(Folder_Name.Text) == false && String.IsNullOrEmpty(Jump_Loc.Text) == false)
            {
                Generate_Button.Enabled = true;
            }
            else {
                Generate_Button.Enabled = false;
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Generate_Button_Click(object sender, EventArgs e)
        {
            try {
                Genelate_Failed.Visible = false;

                if (
                    Directory.Exists(Link_Loc.Text) &&
                    Directory.Exists(Link_Loc.Text + "\\" + Folder_Name.Text) != true &&
                    Directory.Exists(Jump_Loc.Text)
                    )
                {
                    Directory.CreateSymbolicLink(Link_Loc.Text + "\\" + Folder_Name.Text, Jump_Loc.Text);
                    MessageBox.Show("ÉäÉìÉNÇê∂ê¨ÇµÇ‹ÇµÇΩÅB");
                }
                else
                {
                    throw new Exception();
                }

            }
            catch(Exception) {
                Genelate_Failed.Visible = true;
            }
        }
    }
}
