namespace myCookBook
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Filter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.recipePicture = new System.Windows.Forms.PictureBox();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.ingredientsList = new System.Windows.Forms.ListBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.instructionsBox = new System.Windows.Forms.RichTextBox();
            this.approvedLabel = new System.Windows.Forms.Label();
            this.approvedByBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.recipePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.FormattingEnabled = true;
            this.Filter.Items.AddRange(new object[] {
            "Name",
            "Breakfast",
            "Lunch",
            "Dinner",
            "Sweet Treats",
            "Slowcooker",
            "Comfort Food",
            "Soups",
            "Whole30 Approved",
            "Gluten-free",
            "Salads",
            "Vegetarian",
            "Vegan",
            "Paleo",
            "Gameday Foods",
            "Appetizers"});
            this.Filter.Location = new System.Drawing.Point(24, 30);
            this.Filter.MaxDropDownItems = 16;
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(121, 21);
            this.Filter.TabIndex = 0;
            this.Filter.SelectedIndexChanged += new System.EventHandler(this.Filter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kyle\'s Cookbook";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 303);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recipes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(27, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(496, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "+NEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // recipePicture
            // 
            this.recipePicture.Location = new System.Drawing.Point(225, 123);
            this.recipePicture.Name = "recipePicture";
            this.recipePicture.Size = new System.Drawing.Size(103, 102);
            this.recipePicture.TabIndex = 8;
            this.recipePicture.TabStop = false;
            this.recipePicture.Visible = false;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNameLabel.Location = new System.Drawing.Point(220, 93);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(168, 27);
            this.recipeNameLabel.TabIndex = 9;
            this.recipeNameLabel.Text = "Name of the recipe";
            this.recipeNameLabel.Visible = false;
            // 
            // ingredientsList
            // 
            this.ingredientsList.FormattingEnabled = true;
            this.ingredientsList.Location = new System.Drawing.Point(334, 143);
            this.ingredientsList.Name = "ingredientsList";
            this.ingredientsList.Size = new System.Drawing.Size(277, 82);
            this.ingredientsList.TabIndex = 10;
            this.ingredientsList.Visible = false;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.Location = new System.Drawing.Point(334, 123);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(84, 20);
            this.ingredientsLabel.TabIndex = 11;
            this.ingredientsLabel.Text = "Ingredients";
            this.ingredientsLabel.Visible = false;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(225, 235);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(93, 20);
            this.instructionsLabel.TabIndex = 12;
            this.instructionsLabel.Text = "Instructions";
            this.instructionsLabel.Visible = false;
            // 
            // instructionsBox
            // 
            this.instructionsBox.Location = new System.Drawing.Point(225, 258);
            this.instructionsBox.Name = "instructionsBox";
            this.instructionsBox.ReadOnly = true;
            this.instructionsBox.Size = new System.Drawing.Size(386, 74);
            this.instructionsBox.TabIndex = 13;
            this.instructionsBox.Text = "";
            this.instructionsBox.Visible = false;
            // 
            // approvedLabel
            // 
            this.approvedLabel.AutoSize = true;
            this.approvedLabel.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedLabel.Location = new System.Drawing.Point(225, 337);
            this.approvedLabel.Name = "approvedLabel";
            this.approvedLabel.Size = new System.Drawing.Size(42, 20);
            this.approvedLabel.TabIndex = 14;
            this.approvedLabel.Text = "Tags:";
            this.approvedLabel.Visible = false;
            // 
            // approvedByBox
            // 
            this.approvedByBox.Location = new System.Drawing.Point(225, 360);
            this.approvedByBox.Name = "approvedByBox";
            this.approvedByBox.ReadOnly = true;
            this.approvedByBox.Size = new System.Drawing.Size(386, 20);
            this.approvedByBox.TabIndex = 15;
            this.approvedByBox.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(445, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Learn about this app";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(555, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(75, 13);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Change Notes";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(633, 468);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.approvedByBox);
            this.Controls.Add(this.approvedLabel);
            this.Controls.Add(this.instructionsBox);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.ingredientsList);
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.recipePicture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(649, 533);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.recipePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox recipePicture;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.ListBox ingredientsList;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.RichTextBox instructionsBox;
        private System.Windows.Forms.Label approvedLabel;
        private System.Windows.Forms.TextBox approvedByBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}