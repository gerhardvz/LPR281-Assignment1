
namespace LPR281_Assignment1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnObjectiveFunctionChange = new System.Windows.Forms.Button();
            this.btnConstraintRemove = new System.Windows.Forms.Button();
            this.btnConstraintAdd = new System.Windows.Forms.Button();
            this.gbDecisionVariable = new System.Windows.Forms.GroupBox();
            this.lvDecisionVariable = new System.Windows.Forms.ListView();
            this.btnDecisionVariableAdd = new System.Windows.Forms.Button();
            this.btnDecisionVariableRemove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.gbDecisionVariable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnObjectiveFunctionChange);
            this.panel1.Controls.Add(this.btnConstraintRemove);
            this.panel1.Controls.Add(this.btnConstraintAdd);
            this.panel1.Controls.Add(this.gbDecisionVariable);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(612, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 469);
            this.panel1.TabIndex = 3;
            // 
            // btnObjectiveFunctionChange
            // 
            this.btnObjectiveFunctionChange.Location = new System.Drawing.Point(361, 186);
            this.btnObjectiveFunctionChange.Name = "btnObjectiveFunctionChange";
            this.btnObjectiveFunctionChange.Size = new System.Drawing.Size(75, 23);
            this.btnObjectiveFunctionChange.TabIndex = 10;
            this.btnObjectiveFunctionChange.Text = "Set";
            this.btnObjectiveFunctionChange.UseVisualStyleBackColor = true;
            // 
            // btnConstraintRemove
            // 
            this.btnConstraintRemove.Location = new System.Drawing.Point(365, 392);
            this.btnConstraintRemove.Name = "btnConstraintRemove";
            this.btnConstraintRemove.Size = new System.Drawing.Size(75, 23);
            this.btnConstraintRemove.TabIndex = 9;
            this.btnConstraintRemove.Text = "Remove";
            this.btnConstraintRemove.UseVisualStyleBackColor = true;
            // 
            // btnConstraintAdd
            // 
            this.btnConstraintAdd.Location = new System.Drawing.Point(365, 310);
            this.btnConstraintAdd.Name = "btnConstraintAdd";
            this.btnConstraintAdd.Size = new System.Drawing.Size(75, 23);
            this.btnConstraintAdd.TabIndex = 8;
            this.btnConstraintAdd.Text = "Add";
            this.btnConstraintAdd.UseVisualStyleBackColor = true;
            // 
            // gbDecisionVariable
            // 
            this.gbDecisionVariable.Controls.Add(this.lvDecisionVariable);
            this.gbDecisionVariable.Controls.Add(this.btnDecisionVariableAdd);
            this.gbDecisionVariable.Controls.Add(this.btnDecisionVariableRemove);
            this.gbDecisionVariable.Location = new System.Drawing.Point(43, 11);
            this.gbDecisionVariable.Name = "gbDecisionVariable";
            this.gbDecisionVariable.Size = new System.Drawing.Size(410, 116);
            this.gbDecisionVariable.TabIndex = 3;
            this.gbDecisionVariable.TabStop = false;
            this.gbDecisionVariable.Text = "Decision Variable";
            // 
            // lvDecisionVariable
            // 
            this.lvDecisionVariable.FullRowSelect = true;
            this.lvDecisionVariable.GridLines = true;
            this.lvDecisionVariable.HideSelection = false;
            this.lvDecisionVariable.Location = new System.Drawing.Point(13, 23);
            this.lvDecisionVariable.MultiSelect = false;
            this.lvDecisionVariable.Name = "lvDecisionVariable";
            this.lvDecisionVariable.Size = new System.Drawing.Size(288, 87);
            this.lvDecisionVariable.TabIndex = 0;
            this.lvDecisionVariable.UseCompatibleStateImageBehavior = false;
            this.lvDecisionVariable.View = System.Windows.Forms.View.List;
            this.lvDecisionVariable.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvDecisionVariable_ItemSelectionChanged);
            // 
            // btnDecisionVariableAdd
            // 
            this.btnDecisionVariableAdd.Location = new System.Drawing.Point(322, 23);
            this.btnDecisionVariableAdd.Name = "btnDecisionVariableAdd";
            this.btnDecisionVariableAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDecisionVariableAdd.TabIndex = 6;
            this.btnDecisionVariableAdd.Text = "Add";
            this.btnDecisionVariableAdd.UseVisualStyleBackColor = true;
            this.btnDecisionVariableAdd.Click += new System.EventHandler(this.btnDecisionVariableAdd_Click);
            // 
            // btnDecisionVariableRemove
            // 
            this.btnDecisionVariableRemove.Location = new System.Drawing.Point(322, 73);
            this.btnDecisionVariableRemove.Name = "btnDecisionVariableRemove";
            this.btnDecisionVariableRemove.Size = new System.Drawing.Size(75, 23);
            this.btnDecisionVariableRemove.TabIndex = 7;
            this.btnDecisionVariableRemove.Text = "Remove";
            this.btnDecisionVariableRemove.UseVisualStyleBackColor = true;
            this.btnDecisionVariableRemove.Click += new System.EventHandler(this.btnDecisionVariableRemove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView3);
            this.groupBox2.Location = new System.Drawing.Point(43, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 164);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Constraints";
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(6, 22);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(288, 136);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Location = new System.Drawing.Point(43, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Objective Function";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 22);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(288, 72);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 650);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.gbDecisionVariable.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDecisionVariableRemove;
        private System.Windows.Forms.Button btnDecisionVariableAdd;
        private System.Windows.Forms.GroupBox gbDecisionVariable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnObjectiveFunctionChange;
        private System.Windows.Forms.Button btnConstraintRemove;
        private System.Windows.Forms.Button btnConstraintAdd;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView lvDecisionVariable;
    }
}

