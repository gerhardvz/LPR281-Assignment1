
namespace LPR281_Assignment1
{
    partial class ConstraintDialog
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
            this.tblMatrix = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tblMatrix
            // 
          
            this.tblMatrix.Location = new System.Drawing.Point(30, 30);
            this.tblMatrix.Name = "tblMatrix";
            this.tblMatrix.RowCount = 2;
            this.tblMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMatrix.Size = new System.Drawing.Size(929, 104);
            this.tblMatrix.TabIndex = 0;
            this.tblMatrix.ColumnCount = 1;

            foreach (string col in columns)
            {

                this.tblMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Text = col;
                this.tblMatrix.Controls.Add(label, this.tblMatrix.ColumnCount, 0);

                if (this.tblMatrix.ColumnCount == this.columns.Count - 1)
                {
                    System.Windows.Forms.ComboBox cbComparison = new System.Windows.Forms.ComboBox();
                    cbComparison.Name = col;
                    cbComparison.Items.AddRange(new object[] {
            "<",
            ">",
            "="});
                    cbComparison.Size = new System.Drawing.Size(50, 23);
                    this.tblMatrix.Controls.Add(cbComparison, this.tblMatrix.ColumnCount, 1);
                    this.tblMatrix.ColumnCount++;
                    continue;

                }

                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = col + "-multiplier";
                textBox.Size = new System.Drawing.Size(50, 23);

                this.tblMatrix.Controls.Add(textBox, this.tblMatrix.ColumnCount, 1);
                this.tblMatrix.ColumnCount++;
            }
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(744, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(853, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // ConstraintDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tblMatrix);
            this.Name = "ConstraintDialog";
            this.Text = "Constraint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMatrix;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}