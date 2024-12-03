using System;

namespace E_learning
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbTableList = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTableList
            // 
            this.cbTableList.FormattingEnabled = true;
            this.cbTableList.Location = new System.Drawing.Point(108, 9);
            this.cbTableList.Name = "cbTableList";
            this.cbTableList.Size = new System.Drawing.Size(121, 21);
            this.cbTableList.TabIndex = 0;
            cbTableList.SelectedIndexChanged += new EventHandler(cbTableList_SelectedIndexChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(270, 8);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(85, 23);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 379);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.ReadOnly = false;
            this.dataGridView2.AllowUserToAddRows = true;
            this.dataGridView2.AllowUserToDeleteRows = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go to Form 1: Retrieve Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(E_learning.Form1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.cbTableList);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTableList;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}