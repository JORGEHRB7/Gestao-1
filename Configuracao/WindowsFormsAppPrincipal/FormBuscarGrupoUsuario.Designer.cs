namespace WindowsFormsAppPrincipal
{
    partial class FormBuscarGrupoUsuario
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
            this.grupoUsuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuarioDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissoesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.permissoesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddUsuario = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioBindingSource1
            // 
            this.grupoUsuarioBindingSource1.DataSource = typeof(Models.GrupoUsuario);
            // 
            // grupoUsuarioDataGridView1
            // 
            this.grupoUsuarioDataGridView1.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView1.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView1.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView1.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.grupoUsuarioDataGridView1.DataSource = this.grupoUsuarioBindingSource1;
            this.grupoUsuarioDataGridView1.Location = new System.Drawing.Point(12, 106);
            this.grupoUsuarioDataGridView1.Name = "grupoUsuarioDataGridView1";
            this.grupoUsuarioDataGridView1.ReadOnly = true;
            this.grupoUsuarioDataGridView1.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView1.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView1.Size = new System.Drawing.Size(731, 367);
            this.grupoUsuarioDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Grupo de Usuário";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // permissoesBindingSource1
            // 
            this.permissoesBindingSource1.DataMember = "Permissoes";
            this.permissoesBindingSource1.DataSource = this.grupoUsuarioBindingSource1;
            // 
            // permissoesDataGridView1
            // 
            this.permissoesDataGridView1.AllowUserToAddRows = false;
            this.permissoesDataGridView1.AllowUserToDeleteRows = false;
            this.permissoesDataGridView1.AllowUserToOrderColumns = true;
            this.permissoesDataGridView1.AutoGenerateColumns = false;
            this.permissoesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.permissoesDataGridView1.DataSource = this.permissoesBindingSource1;
            this.permissoesDataGridView1.Location = new System.Drawing.Point(749, 106);
            this.permissoesDataGridView1.Name = "permissoesDataGridView1";
            this.permissoesDataGridView1.ReadOnly = true;
            this.permissoesDataGridView1.RowHeadersWidth = 51;
            this.permissoesDataGridView1.RowTemplate.Height = 24;
            this.permissoesDataGridView1.Size = new System.Drawing.Size(436, 367);
            this.permissoesDataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Permissões do Grupo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // buttonAddUsuario
            // 
            this.buttonAddUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddUsuario.Location = new System.Drawing.Point(1030, 76);
            this.buttonAddUsuario.Name = "buttonAddUsuario";
            this.buttonAddUsuario.Size = new System.Drawing.Size(74, 23);
            this.buttonAddUsuario.TabIndex = 3;
            this.buttonAddUsuario.Text = "Adicionar";
            this.buttonAddUsuario.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(1109, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Excluir";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(408, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(426, 77);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Buscar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(506, 76);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Alterar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Location = new System.Drawing.Point(586, 77);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "Adicionar";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Location = new System.Drawing.Point(666, 77);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Excluir";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // FormBuscarGrupoUsuario
            // 
            this.ClientSize = new System.Drawing.Size(1209, 580);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonAddUsuario);
            this.Controls.Add(this.permissoesDataGridView1);
            this.Controls.Add(this.grupoUsuarioDataGridView1);
            this.Name = "FormBuscarGrupoUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.BindingNavigator grupoUsuarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton grupoUsuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource1;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource permissoesBindingSource1;
        private System.Windows.Forms.DataGridView permissoesDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonAddUsuario;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}