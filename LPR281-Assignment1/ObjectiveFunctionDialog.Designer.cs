
namespace LPR281_Assignment1
{
    partial class ObjectiveFunctionDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblMatrix = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblMatrix);
            this.panel1.Location = new System.Drawing.Point(43, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 140);
            this.panel1.TabIndex = 0;
            // 
            // tblMatrix
            // 
           
           
            this.tblMatrix.Location = new System.Drawing.Point(28, 12);
            this.tblMatrix.Name = "tblMatrix";
            this.tblMatrix.RowCount = 2;
            this.tblMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMatrix.Size = new System.Drawing.Size(911, 88);
            this.tblMatrix.TabIndex = 1;
            this.tblMatrix.ColumnCount = 1;
            foreach (string col in columns)
            {

                this.tblMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Text = col;
                this.tblMatrix.Controls.Add(label, this.tblMatrix.ColumnCount, 0);

                  if (this.tblMatrix.ColumnCount == 2)
                  {
                    this.tblMatrix.ColumnCount++;
                       continue;

                  }

                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = col+"-multiplier";
                textBox.Size = new System.Drawing.Size(50, 23);

                this.tblMatrix.Controls.Add(textBox, this.tblMatrix.ColumnCount, 1);
                this.tblMatrix.ColumnCount++;
            }
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(895, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(790, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ObjectiveFunctionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 252);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "ObjectiveFunctionDialog";
            this.Text = "ObjectiveFunctionDialog";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }

   
}