
using System;

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
            this.enterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addName = new System.Windows.Forms.Button();
            this.removeName = new System.Windows.Forms.Button();
            this.selectedName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectName = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.namesEntered = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterName
            // 
            this.enterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterName.Location = new System.Drawing.Point(12, 42);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(245, 13);
            this.enterName.TabIndex = 0;
            this.enterName.TextChanged += new System.EventHandler(this.nameEntere_TextChanged);
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
            this.addName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.addName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addName.Location = new System.Drawing.Point(13, 69);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(75, 23);
            this.addName.TabIndex = 2;
            this.addName.Text = "Agregar";
            this.addName.UseVisualStyleBackColor = false;
            this.addName.Click += new System.EventHandler(this.addName_Click);
            // 
            // removeName
            // 
            this.removeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.removeName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeName.Location = new System.Drawing.Point(182, 69);
            this.removeName.Name = "removeName";
            this.removeName.Size = new System.Drawing.Size(75, 23);
            this.removeName.TabIndex = 3;
            this.removeName.Text = "Eliminar";
            this.removeName.UseVisualStyleBackColor = false;
            this.removeName.Click += new System.EventHandler(this.removeName_Click);
            // 
            // selectedName
            // 
            this.selectedName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectedName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedName.FormattingEnabled = true;
            this.selectedName.Location = new System.Drawing.Point(13, 122);
            this.selectedName.Name = "selectedName";
            this.selectedName.Size = new System.Drawing.Size(244, 130);
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
            this.selectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.selectName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectName.Location = new System.Drawing.Point(12, 263);
            this.selectName.Name = "selectName";
            this.selectName.Size = new System.Drawing.Size(75, 23);
            this.selectName.TabIndex = 7;
            this.selectName.Text = "Seleccionar";
            this.selectName.UseVisualStyleBackColor = false;
            this.selectName.Click += new System.EventHandler(this.selectName_Click);
            // 
            // import
            // 
            this.import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.import.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.import.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.import.Location = new System.Drawing.Point(523, 234);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 8;
            this.import.Text = "Importar";
            this.import.UseVisualStyleBackColor = false;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.export.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.export.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.export.Location = new System.Drawing.Point(523, 263);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 9;
            this.export.Text = "Exportar";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // namesEntered
            // 
            this.namesEntered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.namesEntered.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namesEntered.FormattingEnabled = true;
            this.namesEntered.Location = new System.Drawing.Point(273, 22);
            this.namesEntered.Name = "namesEntered";
            this.namesEntered.Size = new System.Drawing.Size(244, 260);
            this.namesEntered.TabIndex = 4;
            this.namesEntered.SelectedIndexChanged += new System.EventHandler(this.namesEntered_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(10, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Recuerde Guardar la lista antes de usarla";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clean.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clean.Location = new System.Drawing.Point(452, 292);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(51, 23);
            this.clean.TabIndex = 11;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 328);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.export);
            this.Controls.Add(this.import);
            this.Controls.Add(this.selectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedName);
            this.Controls.Add(this.namesEntered);
            this.Controls.Add(this.removeName);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Name Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void nameEntere_TextChanged(object sender, EventArgs e)
        {
         // throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox enterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addName;
        private System.Windows.Forms.Button removeName;
        private System.Windows.Forms.ListBox selectedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectName;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.ListBox namesEntered;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clean;
    }
}

