
namespace NamePicker
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameEntered = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addName = new System.Windows.Forms.Button();
            this.removeName = new System.Windows.Forms.Button();
            this.namesEntered = new System.Windows.Forms.ListBox();
            this.selectedName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectName = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameEntered
            // 
            this.nameEntered.Location = new System.Drawing.Point(12, 42);
            this.nameEntered.Name = "nameEntered";
            this.nameEntered.Size = new System.Drawing.Size(171, 20);
            this.nameEntered.TabIndex = 0;
            this.nameEntered.TextChanged += new System.EventHandler(this.nameEntered_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese nombres:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(13, 69);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(75, 23);
            this.addName.TabIndex = 2;
            this.addName.Text = "Agregar";
            this.addName.UseVisualStyleBackColor = true;
            this.addName.Click += new System.EventHandler(this.addName_Click);
            // 
            // removeName
            // 
            this.removeName.Location = new System.Drawing.Point(108, 69);
            this.removeName.Name = "removeName";
            this.removeName.Size = new System.Drawing.Size(75, 23);
            this.removeName.TabIndex = 3;
            this.removeName.Text = "Eliminar";
            this.removeName.UseVisualStyleBackColor = true;
            this.removeName.Click += new System.EventHandler(this.removeName_Click);
            // 
            // namesEntered
            // 
            this.namesEntered.FormattingEnabled = true;
            this.namesEntered.Location = new System.Drawing.Point(220, 13);
            this.namesEntered.Name = "namesEntered";
            this.namesEntered.Size = new System.Drawing.Size(255, 264);
            this.namesEntered.TabIndex = 4;
            this.namesEntered.SelectedIndexChanged += new System.EventHandler(this.namesEntered_SelectedIndexChanged);
            // 
            // selectedName
            // 
            this.selectedName.FormattingEnabled = true;
            this.selectedName.Location = new System.Drawing.Point(13, 123);
            this.selectedName.Name = "selectedName";
            this.selectedName.Size = new System.Drawing.Size(170, 121);
            this.selectedName.TabIndex = 5;
            this.selectedName.SelectedIndexChanged += new System.EventHandler(this.selectedName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre seleccionado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // selectName
            // 
            this.selectName.Location = new System.Drawing.Point(29, 253);
            this.selectName.Name = "selectName";
            this.selectName.Size = new System.Drawing.Size(75, 23);
            this.selectName.TabIndex = 7;
            this.selectName.Text = "Seleccionar";
            this.selectName.UseVisualStyleBackColor = true;
            this.selectName.Click += new System.EventHandler(this.selectName_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(481, 221);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 8;
            this.import.Text = "Importar";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(481, 254);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 9;
            this.export.Text = "Exportar";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 326);
            this.Controls.Add(this.export);
            this.Controls.Add(this.import);
            this.Controls.Add(this.selectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedName);
            this.Controls.Add(this.namesEntered);
            this.Controls.Add(this.removeName);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameEntered);
            this.Name = "Form1";
            this.Text = "Name Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameEntered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addName;
        private System.Windows.Forms.Button removeName;
        private System.Windows.Forms.ListBox namesEntered;
        private System.Windows.Forms.ListBox selectedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectName;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button export;
    }
}

