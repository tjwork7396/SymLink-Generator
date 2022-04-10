namespace SymLink_Generator
{
    partial class Symlink_Generater
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Link_Loc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Jump_Loc = new System.Windows.Forms.TextBox();
            this.Folder_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Generate_Button = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Link_Loc_button = new System.Windows.Forms.Button();
            this.Jump_Loc_button = new System.Windows.Forms.Button();
            this.Link_Path_Error = new System.Windows.Forms.Label();
            this.Folder_Exist = new System.Windows.Forms.Label();
            this.Path_Error = new System.Windows.Forms.Label();
            this.Genelate_Failed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "リンクを貼りたい場所";
            // 
            // Link_Loc
            // 
            this.Link_Loc.Location = new System.Drawing.Point(123, 27);
            this.Link_Loc.Name = "Link_Loc";
            this.Link_Loc.Size = new System.Drawing.Size(532, 23);
            this.Link_Loc.TabIndex = 1;
            this.Link_Loc.TextChanged += new System.EventHandler(this.Link_Loc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "リンクの向き先";
            // 
            // Jump_Loc
            // 
            this.Jump_Loc.Location = new System.Drawing.Point(123, 147);
            this.Jump_Loc.Name = "Jump_Loc";
            this.Jump_Loc.Size = new System.Drawing.Size(532, 23);
            this.Jump_Loc.TabIndex = 1;
            this.Jump_Loc.TextChanged += new System.EventHandler(this.Jump_Loc_TextChanged_1);
            // 
            // Folder_Name
            // 
            this.Folder_Name.Enabled = false;
            this.Folder_Name.Location = new System.Drawing.Point(472, 71);
            this.Folder_Name.Name = "Folder_Name";
            this.Folder_Name.Size = new System.Drawing.Size(183, 23);
            this.Folder_Name.TabIndex = 1;
            this.Folder_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Folder_Name.TextChanged += new System.EventHandler(this.Folder_Name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "フォルダ名";
            // 
            // Generate_Button
            // 
            this.Generate_Button.Enabled = false;
            this.Generate_Button.Location = new System.Drawing.Point(603, 239);
            this.Generate_Button.Name = "Generate_Button";
            this.Generate_Button.Size = new System.Drawing.Size(125, 86);
            this.Generate_Button.TabIndex = 2;
            this.Generate_Button.Text = "リンク生成";
            this.Generate_Button.UseVisualStyleBackColor = true;
            this.Generate_Button.Click += new System.EventHandler(this.Generate_Button_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(472, 266);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(110, 59);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "キャンセル";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Link_Loc_button
            // 
            this.Link_Loc_button.Location = new System.Drawing.Point(661, 27);
            this.Link_Loc_button.Name = "Link_Loc_button";
            this.Link_Loc_button.Size = new System.Drawing.Size(34, 26);
            this.Link_Loc_button.TabIndex = 2;
            this.Link_Loc_button.Text = "…";
            this.Link_Loc_button.UseVisualStyleBackColor = true;
            this.Link_Loc_button.Click += new System.EventHandler(this.Link_Loc_button_Click);
            // 
            // Jump_Loc_button
            // 
            this.Jump_Loc_button.Location = new System.Drawing.Point(661, 147);
            this.Jump_Loc_button.Name = "Jump_Loc_button";
            this.Jump_Loc_button.Size = new System.Drawing.Size(34, 23);
            this.Jump_Loc_button.TabIndex = 2;
            this.Jump_Loc_button.Text = "…";
            this.Jump_Loc_button.UseVisualStyleBackColor = true;
            this.Jump_Loc_button.Click += new System.EventHandler(this.Jump_Loc_button_Click);
            // 
            // Link_Path_Error
            // 
            this.Link_Path_Error.AutoSize = true;
            this.Link_Path_Error.ForeColor = System.Drawing.Color.Red;
            this.Link_Path_Error.Location = new System.Drawing.Point(567, 53);
            this.Link_Path_Error.Name = "Link_Path_Error";
            this.Link_Path_Error.Size = new System.Drawing.Size(88, 15);
            this.Link_Path_Error.TabIndex = 0;
            this.Link_Path_Error.Text = "無効なパスです。";
            this.Link_Path_Error.Visible = false;
            // 
            // Folder_Exist
            // 
            this.Folder_Exist.AutoSize = true;
            this.Folder_Exist.ForeColor = System.Drawing.Color.Red;
            this.Folder_Exist.Location = new System.Drawing.Point(521, 97);
            this.Folder_Exist.Name = "Folder_Exist";
            this.Folder_Exist.Size = new System.Drawing.Size(134, 15);
            this.Folder_Exist.TabIndex = 0;
            this.Folder_Exist.Text = "既に存在するフォルダです。\r\n";
            this.Folder_Exist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Folder_Exist.Visible = false;
            // 
            // Path_Error
            // 
            this.Path_Error.AutoSize = true;
            this.Path_Error.ForeColor = System.Drawing.Color.Red;
            this.Path_Error.Location = new System.Drawing.Point(567, 173);
            this.Path_Error.Name = "Path_Error";
            this.Path_Error.Size = new System.Drawing.Size(88, 15);
            this.Path_Error.TabIndex = 0;
            this.Path_Error.Text = "無効なパスです。";
            this.Path_Error.Visible = false;
            // 
            // Genelate_Failed
            // 
            this.Genelate_Failed.AutoSize = true;
            this.Genelate_Failed.ForeColor = System.Drawing.Color.Red;
            this.Genelate_Failed.Location = new System.Drawing.Point(316, 335);
            this.Genelate_Failed.Name = "Genelate_Failed";
            this.Genelate_Failed.Size = new System.Drawing.Size(412, 15);
            this.Genelate_Failed.TabIndex = 0;
            this.Genelate_Failed.Text = "生成に失敗しました。リンクを貼る場所と向き先、フォルダ名をもう一度確認して下さい。";
            this.Genelate_Failed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Genelate_Failed.Visible = false;
            // 
            // Symlink_Generater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 359);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Jump_Loc_button);
            this.Controls.Add(this.Link_Loc_button);
            this.Controls.Add(this.Generate_Button);
            this.Controls.Add(this.Jump_Loc);
            this.Controls.Add(this.Folder_Name);
            this.Controls.Add(this.Link_Loc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Genelate_Failed);
            this.Controls.Add(this.Folder_Exist);
            this.Controls.Add(this.Path_Error);
            this.Controls.Add(this.Link_Path_Error);
            this.Controls.Add(this.label1);
            this.Name = "Symlink_Generater";
            this.Text = "Symlinkジェネレーター";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Link_Loc;
        private Label label2;
        private TextBox Jump_Loc;
        private TextBox Folder_Name;
        private Label label3;
        private Button Generate_Button;
        private Button Cancel;
        private Button Link_Loc_button;
        private Button Jump_Loc_button;
        private Label Link_Path_Error;
        private Label Folder_Exist;
        private Label Path_Error;
        private Label Genelate_Failed;
    }
}