using System.Windows.Forms;
using System.Windows.Markup;
namespace myGameTest {
    public partial class MainView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Lbl_HitPointsText = new System.Windows.Forms.Label();
            this.Lbl_HitPointsHealth = new System.Windows.Forms.Label();
            this.Btn_Attack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Gold = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dgv_Inventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_HitPointsText
            // 
            this.Lbl_HitPointsText.AutoSize = true;
            this.Lbl_HitPointsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HitPointsText.Location = new System.Drawing.Point(6, 18);
            this.Lbl_HitPointsText.Name = "Lbl_HitPointsText";
            this.Lbl_HitPointsText.Size = new System.Drawing.Size(100, 25);
            this.Lbl_HitPointsText.TabIndex = 0;
            this.Lbl_HitPointsText.Text = "Hit Points:";
            this.Lbl_HitPointsText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_HitPointsHealth
            // 
            this.Lbl_HitPointsHealth.AutoSize = true;
            this.Lbl_HitPointsHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HitPointsHealth.Location = new System.Drawing.Point(120, 18);
            this.Lbl_HitPointsHealth.Name = "Lbl_HitPointsHealth";
            this.Lbl_HitPointsHealth.Size = new System.Drawing.Size(23, 25);
            this.Lbl_HitPointsHealth.TabIndex = 1;
            this.Lbl_HitPointsHealth.Text = "0";
            this.Lbl_HitPointsHealth.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn_Attack
            // 
            this.Btn_Attack.Location = new System.Drawing.Point(31, 587);
            this.Btn_Attack.Name = "Btn_Attack";
            this.Btn_Attack.Size = new System.Drawing.Size(75, 23);
            this.Btn_Attack.TabIndex = 3;
            this.Btn_Attack.Text = "Attack";
            this.Btn_Attack.UseVisualStyleBackColor = true;
            this.Btn_Attack.Click += new System.EventHandler(this.Btn_Attack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gold:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Lbl_Gold
            // 
            this.Lbl_Gold.AutoSize = true;
            this.Lbl_Gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Gold.Location = new System.Drawing.Point(120, 43);
            this.Lbl_Gold.Name = "Lbl_Gold";
            this.Lbl_Gold.Size = new System.Drawing.Size(23, 25);
            this.Lbl_Gold.TabIndex = 5;
            this.Lbl_Gold.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Experience:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(263, 443);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // dgv_Inventory
            // 
            this.dgv_Inventory.AccessibleName = "Inventory";
            this.dgv_Inventory.AllowUserToAddRows = false;
            this.dgv_Inventory.AllowUserToDeleteRows = false;
            this.dgv_Inventory.AllowUserToResizeColumns = false;
            this.dgv_Inventory.AllowUserToResizeRows = false;
            this.dgv_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventory.EnableHeadersVisualStyles = false;
            this.dgv_Inventory.Location = new System.Drawing.Point(679, 18);
            this.dgv_Inventory.Name = "dgv_Inventory";
            this.dgv_Inventory.ReadOnly = true;
            this.dgv_Inventory.RowHeadersVisible = false;
            this.dgv_Inventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Inventory.RowTemplate.Height = 20;
            this.dgv_Inventory.RowTemplate.ReadOnly = true;
            this.dgv_Inventory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Inventory.Size = new System.Drawing.Size(240, 297);
            this.dgv_Inventory.TabIndex = 11;
            this.dgv_Inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Inventory_CellContentClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 682);
            this.Controls.Add(this.dgv_Inventory);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Gold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Attack);
            this.Controls.Add(this.Lbl_HitPointsHealth);
            this.Controls.Add(this.Lbl_HitPointsText);
            this.Name = "MainView";
            this.Text = "MainViewModel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_HitPointsText;
        private System.Windows.Forms.Label Lbl_HitPointsHealth;
        private System.Windows.Forms.Button Btn_Attack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Gold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DataGridView dgv_Inventory;

        public MainView() {
            InitializeComponent();
            Lbl_HitPointsHealth.DataBindings.Add("Text", viewModel.CurrentPlayer(), "CurrentHitPoints");
            dgv_Inventory.DataSource = viewModel.CurrentPlayer().ListOfInventory;
            

        }

    }
}