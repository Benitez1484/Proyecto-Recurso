namespace Tareas
{
    partial class Pantalla_Tareas
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvAdministrador = new MetroFramework.Controls.MetroGrid();
			this.dgvProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.agvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvVirtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnActualizar = new MetroFramework.Controls.MetroTile();
			this.btnDetener = new MetroFramework.Controls.MetroTile();
			this.btnSalir = new MetroFramework.Controls.MetroTile();
			this.txtContador = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProceso = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAdministrador
			// 
			this.dgvAdministrador.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
			this.dgvAdministrador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAdministrador.BackgroundColor = System.Drawing.Color.White;
			this.dgvAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAdministrador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvAdministrador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAdministrador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAdministrador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProceso,
            this.agvID,
            this.dgvFisica,
            this.dgvVirtual,
            this.dgvCPU});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAdministrador.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvAdministrador.EnableHeadersVisualStyles = false;
			this.dgvAdministrador.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvAdministrador.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvAdministrador.Location = new System.Drawing.Point(23, 85);
			this.dgvAdministrador.Name = "dgvAdministrador";
			this.dgvAdministrador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAdministrador.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvAdministrador.RowHeadersWidth = 51;
			this.dgvAdministrador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvAdministrador.RowTemplate.Height = 24;
			this.dgvAdministrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAdministrador.Size = new System.Drawing.Size(972, 409);
			this.dgvAdministrador.TabIndex = 0;
			this.dgvAdministrador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdministrador_CellContentClick);
			// 
			// dgvProceso
			// 
			this.dgvProceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgvProceso.HeaderText = "Proceso";
			this.dgvProceso.MinimumWidth = 6;
			this.dgvProceso.Name = "dgvProceso";
			// 
			// agvID
			// 
			this.agvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.agvID.HeaderText = "ID";
			this.agvID.MinimumWidth = 6;
			this.agvID.Name = "agvID";
			// 
			// dgvFisica
			// 
			this.dgvFisica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgvFisica.HeaderText = "Memoria Fisica";
			this.dgvFisica.MinimumWidth = 6;
			this.dgvFisica.Name = "dgvFisica";
			// 
			// dgvVirtual
			// 
			this.dgvVirtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgvVirtual.HeaderText = "Memoria Virtual";
			this.dgvVirtual.MinimumWidth = 6;
			this.dgvVirtual.Name = "dgvVirtual";
			// 
			// dgvCPU
			// 
			this.dgvCPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgvCPU.HeaderText = "CPU";
			this.dgvCPU.MinimumWidth = 6;
			this.dgvCPU.Name = "dgvCPU";
			// 
			// btnActualizar
			// 
			this.btnActualizar.ActiveControl = null;
			this.btnActualizar.BackColor = System.Drawing.Color.Silver;
			this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.btnActualizar.Location = new System.Drawing.Point(23, 628);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(144, 49);
			this.btnActualizar.Style = MetroFramework.MetroColorStyle.Lime;
			this.btnActualizar.TabIndex = 1;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnActualizar.UseSelectable = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnDetener
			// 
			this.btnDetener.ActiveControl = null;
			this.btnDetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnDetener.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnDetener.Location = new System.Drawing.Point(209, 628);
			this.btnDetener.Name = "btnDetener";
			this.btnDetener.Size = new System.Drawing.Size(144, 49);
			this.btnDetener.Style = MetroFramework.MetroColorStyle.Silver;
			this.btnDetener.TabIndex = 2;
			this.btnDetener.Text = "Detener";
			this.btnDetener.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnDetener.UseSelectable = true;
			this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.ActiveControl = null;
			this.btnSalir.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnSalir.Location = new System.Drawing.Point(828, 640);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(123, 50);
			this.btnSalir.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// txtContador
			// 
			this.txtContador.AutoSize = true;
			this.txtContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContador.ForeColor = System.Drawing.SystemColors.Desktop;
			this.txtContador.Location = new System.Drawing.Point(48, 543);
			this.txtContador.Name = "txtContador";
			this.txtContador.Size = new System.Drawing.Size(53, 20);
			this.txtContador.TabIndex = 4;
			this.txtContador.Text = "label1";
			this.txtContador.Click += new System.EventHandler(this.txtContador_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(335, 543);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nombre del Proceso:";
			// 
			// txtProceso
			// 
			this.txtProceso.AutoSize = true;
			this.txtProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProceso.ForeColor = System.Drawing.SystemColors.Desktop;
			this.txtProceso.Location = new System.Drawing.Point(608, 543);
			this.txtProceso.Name = "txtProceso";
			this.txtProceso.Size = new System.Drawing.Size(18, 20);
			this.txtProceso.TabIndex = 6;
			this.txtProceso.Text = "0";
			// 
			// Pantalla_Tareas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1017, 713);
			this.Controls.Add(this.txtProceso);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtContador);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnDetener);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.dgvAdministrador);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "Pantalla_Tareas";
			this.Text = "ADMINISTRADOR DE TAREA";
			this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
			this.TransparencyKey = System.Drawing.Color.DimGray;
			this.Load += new System.EventHandler(this.PantallaTareas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvAdministrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn agvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVirtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCPU;
        private MetroFramework.Controls.MetroTile btnActualizar;
        private MetroFramework.Controls.MetroTile btnDetener;
        private MetroFramework.Controls.MetroTile btnSalir;
        private System.Windows.Forms.Label txtContador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtProceso;
        private System.Windows.Forms.Timer timer1;
    }
}

