namespace ProjetCantine
{
    partial class Form_ParamRepasPrix
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
            this.dataGridView_RepasPrix = new System.Windows.Forms.DataGridView();
            this.tAprixdesrepasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Cantine = new ProjetCantine.Models.DataSet_Cantine();
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_Prix = new System.Windows.Forms.Label();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Prix = new System.Windows.Forms.TextBox();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.tA_prix_des_repasTableAdapter = new ProjetCantine.Models.DataSet_CantineTableAdapters.TA_prix_des_repasTableAdapter();
            this.typerepasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RepasPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAprixdesrepasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Cantine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_RepasPrix
            // 
            this.dataGridView_RepasPrix.AutoGenerateColumns = false;
            this.dataGridView_RepasPrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_RepasPrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RepasPrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typerepasDataGridViewTextBoxColumn,
            this.datedebutDataGridViewTextBoxColumn,
            this.datefinDataGridViewTextBoxColumn,
            this.prix});
            this.dataGridView_RepasPrix.DataSource = this.tAprixdesrepasBindingSource;
            this.dataGridView_RepasPrix.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_RepasPrix.Name = "dataGridView_RepasPrix";
            this.dataGridView_RepasPrix.Size = new System.Drawing.Size(1060, 513);
            this.dataGridView_RepasPrix.TabIndex = 0;
            this.dataGridView_RepasPrix.TabStop = false;
            // 
            // tAprixdesrepasBindingSource
            // 
            this.tAprixdesrepasBindingSource.DataMember = "TA_prix_des_repas";
            this.tAprixdesrepasBindingSource.DataSource = this.dataSet_Cantine;
            // 
            // dataSet_Cantine
            // 
            this.dataSet_Cantine.DataSetName = "DataSet_Cantine";
            this.dataSet_Cantine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(145, 556);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(76, 13);
            this.label_Nom.TabIndex = 1;
            this.label_Nom.Text = "Nom du repas ";
            // 
            // label_Prix
            // 
            this.label_Prix.AutoSize = true;
            this.label_Prix.Location = new System.Drawing.Point(145, 582);
            this.label_Prix.Name = "label_Prix";
            this.label_Prix.Size = new System.Drawing.Size(68, 13);
            this.label_Prix.TabIndex = 2;
            this.label_Prix.Text = "Prix du repas";
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(230, 553);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(200, 20);
            this.textBox_Nom.TabIndex = 10;
            // 
            // textBox_Prix
            // 
            this.textBox_Prix.Location = new System.Drawing.Point(230, 579);
            this.textBox_Prix.Name = "textBox_Prix";
            this.textBox_Prix.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prix.TabIndex = 15;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(352, 600);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(150, 23);
            this.button_Ajouter.TabIndex = 20;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(607, 600);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(150, 23);
            this.button_Supprimer.TabIndex = 25;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            // 
            // tA_prix_des_repasTableAdapter
            // 
            this.tA_prix_des_repasTableAdapter.ClearBeforeFill = true;
            // 
            // typerepasDataGridViewTextBoxColumn
            // 
            this.typerepasDataGridViewTextBoxColumn.DataPropertyName = "type_repas";
            this.typerepasDataGridViewTextBoxColumn.HeaderText = "Type de repas";
            this.typerepasDataGridViewTextBoxColumn.Name = "typerepasDataGridViewTextBoxColumn";
            // 
            // datedebutDataGridViewTextBoxColumn
            // 
            this.datedebutDataGridViewTextBoxColumn.DataPropertyName = "date_debut";
            this.datedebutDataGridViewTextBoxColumn.HeaderText = "Date début";
            this.datedebutDataGridViewTextBoxColumn.Name = "datedebutDataGridViewTextBoxColumn";
            // 
            // datefinDataGridViewTextBoxColumn
            // 
            this.datefinDataGridViewTextBoxColumn.DataPropertyName = "date_fin";
            this.datefinDataGridViewTextBoxColumn.HeaderText = "Date fin";
            this.datefinDataGridViewTextBoxColumn.Name = "datefinDataGridViewTextBoxColumn";
            // 
            // prix
            // 
            this.prix.DataPropertyName = "prix";
            this.prix.HeaderText = "Prix en €";
            this.prix.Name = "prix";
            // 
            // Form_ParamRepasPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.ControlBox = false;
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.textBox_Prix);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.label_Prix);
            this.Controls.Add(this.label_Nom);
            this.Controls.Add(this.dataGridView_RepasPrix);
            this.Name = "Form_ParamRepasPrix";
            this.Text = "Paramétrage des repas et des prix";
            this.Load += new System.EventHandler(this.Form_ParamRepasPrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RepasPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAprixdesrepasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Cantine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_RepasPrix;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Label label_Prix;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Prix;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Button button_Supprimer;
        private Models.DataSet_Cantine dataSet_Cantine;
        private System.Windows.Forms.BindingSource tAprixdesrepasBindingSource;
        private Models.DataSet_CantineTableAdapters.TA_prix_des_repasTableAdapter tA_prix_des_repasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typerepasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
    }
}