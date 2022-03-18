
namespace Parcial2DB
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            System.Windows.Forms.Label código_AutomotorLabel;
            System.Windows.Forms.Label patenteLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label estadoLabel;
            this.automotorDataSet = new Parcial2DB.AutomotorDataSet();
            this.automotorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automotorTableAdapter = new Parcial2DB.AutomotorDataSetTableAdapters.AutomotorTableAdapter();
            this.tableAdapterManager = new Parcial2DB.AutomotorDataSetTableAdapters.TableAdapterManager();
            this.automotorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.automotorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.código_AutomotorTextBox = new System.Windows.Forms.TextBox();
            this.patenteTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.automotorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            código_AutomotorLabel = new System.Windows.Forms.Label();
            patenteLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automotorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotorBindingNavigator)).BeginInit();
            this.automotorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automotorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // automotorDataSet
            // 
            this.automotorDataSet.DataSetName = "AutomotorDataSet";
            this.automotorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automotorBindingSource
            // 
            this.automotorBindingSource.DataMember = "Automotor";
            this.automotorBindingSource.DataSource = this.automotorDataSet;
            // 
            // automotorTableAdapter
            // 
            this.automotorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutomotorTableAdapter = this.automotorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Parcial2DB.AutomotorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // automotorBindingNavigator
            // 
            this.automotorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.automotorBindingNavigator.BindingSource = this.automotorBindingSource;
            this.automotorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.automotorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.automotorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.automotorBindingNavigatorSaveItem});
            this.automotorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.automotorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.automotorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.automotorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.automotorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.automotorBindingNavigator.Name = "automotorBindingNavigator";
            this.automotorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.automotorBindingNavigator.Size = new System.Drawing.Size(588, 25);
            this.automotorBindingNavigator.TabIndex = 0;
            this.automotorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // automotorBindingNavigatorSaveItem
            // 
            this.automotorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.automotorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("automotorBindingNavigatorSaveItem.Image")));
            this.automotorBindingNavigatorSaveItem.Name = "automotorBindingNavigatorSaveItem";
            this.automotorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.automotorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.automotorBindingNavigatorSaveItem.Click += new System.EventHandler(this.automotorBindingNavigatorSaveItem_Click);
            // 
            // código_AutomotorLabel
            // 
            código_AutomotorLabel.AutoSize = true;
            código_AutomotorLabel.Location = new System.Drawing.Point(12, 42);
            código_AutomotorLabel.Name = "código_AutomotorLabel";
            código_AutomotorLabel.Size = new System.Drawing.Size(94, 13);
            código_AutomotorLabel.TabIndex = 1;
            código_AutomotorLabel.Text = "Código Automotor:";
            // 
            // código_AutomotorTextBox
            // 
            this.código_AutomotorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.automotorBindingSource, "Código Automotor", true));
            this.código_AutomotorTextBox.Location = new System.Drawing.Point(112, 39);
            this.código_AutomotorTextBox.Name = "código_AutomotorTextBox";
            this.código_AutomotorTextBox.Size = new System.Drawing.Size(100, 20);
            this.código_AutomotorTextBox.TabIndex = 2;
            // 
            // patenteLabel
            // 
            patenteLabel.AutoSize = true;
            patenteLabel.Location = new System.Drawing.Point(12, 68);
            patenteLabel.Name = "patenteLabel";
            patenteLabel.Size = new System.Drawing.Size(47, 13);
            patenteLabel.TabIndex = 3;
            patenteLabel.Text = "Patente:";
            // 
            // patenteTextBox
            // 
            this.patenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.automotorBindingSource, "Patente", true));
            this.patenteTextBox.Location = new System.Drawing.Point(112, 65);
            this.patenteTextBox.Name = "patenteTextBox";
            this.patenteTextBox.Size = new System.Drawing.Size(100, 20);
            this.patenteTextBox.TabIndex = 4;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(12, 94);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 5;
            modeloLabel.Text = "Modelo:";
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.automotorBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(112, 91);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(100, 20);
            this.modeloTextBox.TabIndex = 6;
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(12, 120);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 7;
            marcaLabel.Text = "Marca:";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.automotorBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(112, 117);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox.TabIndex = 8;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(12, 146);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 9;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.automotorBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(112, 143);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 10;
            // 
            // automotorDataGridView
            // 
            this.automotorDataGridView.AutoGenerateColumns = false;
            this.automotorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.automotorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.automotorDataGridView.DataSource = this.automotorBindingSource;
            this.automotorDataGridView.Location = new System.Drawing.Point(15, 208);
            this.automotorDataGridView.Name = "automotorDataGridView";
            this.automotorDataGridView.Size = new System.Drawing.Size(545, 220);
            this.automotorDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Código Automotor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Automotor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Patente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn4.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 520);
            this.Controls.Add(this.automotorDataGridView);
            this.Controls.Add(código_AutomotorLabel);
            this.Controls.Add(this.código_AutomotorTextBox);
            this.Controls.Add(patenteLabel);
            this.Controls.Add(this.patenteTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.automotorBindingNavigator);
            this.Name = "frmAgregar";
            this.Text = "frmAgregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automotorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotorBindingNavigator)).EndInit();
            this.automotorBindingNavigator.ResumeLayout(false);
            this.automotorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automotorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutomotorDataSet automotorDataSet;
        private System.Windows.Forms.BindingSource automotorBindingSource;
        private AutomotorDataSetTableAdapters.AutomotorTableAdapter automotorTableAdapter;
        private AutomotorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator automotorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton automotorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox código_AutomotorTextBox;
        private System.Windows.Forms.TextBox patenteTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DataGridView automotorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}