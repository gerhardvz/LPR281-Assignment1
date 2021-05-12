
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.panel1.SuspendLayout();
            this.tblMatrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblMatrix);
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Location = new System.Drawing.Point(43, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 216);
            this.panel1.TabIndex = 0;
            // 
            // tblMatrix
            // 
           
            this.tblMatrix.RowCount = 2;

            this.tblMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
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
                textBox.Size = new System.Drawing.Size(50, 23);

                this.tblMatrix.Controls.Add(textBox, this.tblMatrix.ColumnCount, 1);
                this.tblMatrix.ColumnCount++;
            }

          
            
            this.tblMatrix.Location = new System.Drawing.Point(28, 12);
            this.tblMatrix.Name = "tblMatrix";
     
            this.tblMatrix.Size = new System.Drawing.Size(911, 183);
            this.tblMatrix.TabIndex = 1;
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
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 198);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(958, 17);
            this.hScrollBar1.TabIndex = 0;
            // 
            // ObjectiveFunctionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 317);
            this.Controls.Add(this.panel1);
            this.Name = "ObjectiveFunctionDialog";
            this.Text = "ObjectiveFunctionDialog";
            this.panel1.ResumeLayout(false);
            this.tblMatrix.ResumeLayout(false);
            this.tblMatrix.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}