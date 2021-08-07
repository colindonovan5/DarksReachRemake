namespace DarksReachRemake
{
    partial class DarksReachForm
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
            this.DarksReachTopLabel = new System.Windows.Forms.Label();
            this.MapPanel = new System.Windows.Forms.Panel();
            this.RoomDescriptionLabel = new System.Windows.Forms.Label();
            this.NorthButton = new System.Windows.Forms.Button();
            this.WestButton = new System.Windows.Forms.Button();
            this.SouthButton = new System.Windows.Forms.Button();
            this.EastButton = new System.Windows.Forms.Button();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.EquipButton = new System.Windows.Forms.Button();
            this.EquippedWeaponTitleLabel = new System.Windows.Forms.Label();
            this.EquippedWeaponLabel = new System.Windows.Forms.Label();
            this.PlayerHealthLabel = new System.Windows.Forms.Label();
            this.PlayerDamageLabel = new System.Windows.Forms.Label();
            this.PlayerManaLabel = new System.Windows.Forms.Label();
            this.PlayerXAndYLabel = new System.Windows.Forms.Label();
            this.PlayerRoomLabel = new System.Windows.Forms.Label();
            this.PlayerStatsLabel = new System.Windows.Forms.Label();
            this.BattleBeginButton = new System.Windows.Forms.Button();
            this.CombatPanel = new System.Windows.Forms.Panel();
            this.EnemyBurnedLabel = new System.Windows.Forms.Label();
            this.EnemyDamagedLabel = new System.Windows.Forms.Label();
            this.DamageTakenLabel = new System.Windows.Forms.Label();
            this.FailedEscapeLabel = new System.Windows.Forms.Label();
            this.CombatTextLabel = new System.Windows.Forms.Label();
            this.LevelUpPanel = new System.Windows.Forms.Panel();
            this.ExtraInfoLabel = new System.Windows.Forms.Label();
            this.FinishAllocationButton = new System.Windows.Forms.Button();
            this.SkillPointsLabel = new System.Windows.Forms.Label();
            this.IncreaseWisdomButton = new System.Windows.Forms.Button();
            this.IncreaseVitalityButton = new System.Windows.Forms.Button();
            this.IncreaseStrengthButton = new System.Windows.Forms.Button();
            this.PlayerWisdomLabel = new System.Windows.Forms.Label();
            this.PlayerVitalityLabel = new System.Windows.Forms.Label();
            this.PlayerStrengthLabel = new System.Windows.Forms.Label();
            this.EnemyNameLabel = new System.Windows.Forms.Label();
            this.EnemyStatsLabel = new System.Windows.Forms.Label();
            this.EnemyDamageLabel = new System.Windows.Forms.Label();
            this.EnemyHealthLabel = new System.Windows.Forms.Label();
            this.InventoryTitleLabel = new System.Windows.Forms.Label();
            this.UseItemButton = new System.Windows.Forms.Button();
            this.AttackButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.MagicButton = new System.Windows.Forms.Button();
            this.RestButton = new System.Windows.Forms.Button();
            this.PlayerLeveLLabel = new System.Windows.Forms.Label();
            this.PlayerXPLabel = new System.Windows.Forms.Label();
            this.OpenChestButton = new System.Windows.Forms.Button();
            this.PlayerSpellsListBox = new System.Windows.Forms.ListBox();
            this.CastSpellButton = new System.Windows.Forms.Button();
            this.CurrentQuestLabel = new System.Windows.Forms.Label();
            this.CurrentQuestDescriptionLabel = new System.Windows.Forms.Label();
            this.CurrentQuestPanel = new System.Windows.Forms.Panel();
            this.QuestRewardLabel = new System.Windows.Forms.Label();
            this.AcceptQuestButton = new System.Windows.Forms.Button();
            this.CompleteQuestButton = new System.Windows.Forms.Button();
            this.UseInventoryItemButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.GoUpButton = new System.Windows.Forms.Button();
            this.PlayerFloorLabel = new System.Windows.Forms.Label();
            this.GoDownButton = new System.Windows.Forms.Button();
            this.MapPanel.SuspendLayout();
            this.CombatPanel.SuspendLayout();
            this.LevelUpPanel.SuspendLayout();
            this.CurrentQuestPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DarksReachTopLabel
            // 
            this.DarksReachTopLabel.AutoSize = true;
            this.DarksReachTopLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarksReachTopLabel.Location = new System.Drawing.Point(700, 58);
            this.DarksReachTopLabel.Name = "DarksReachTopLabel";
            this.DarksReachTopLabel.Size = new System.Drawing.Size(153, 25);
            this.DarksReachTopLabel.TabIndex = 0;
            this.DarksReachTopLabel.Text = "Dark\'s Reach";
            // 
            // MapPanel
            // 
            this.MapPanel.Controls.Add(this.GoDownButton);
            this.MapPanel.Controls.Add(this.GoUpButton);
            this.MapPanel.Controls.Add(this.RoomDescriptionLabel);
            this.MapPanel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapPanel.Location = new System.Drawing.Point(611, 198);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(339, 325);
            this.MapPanel.TabIndex = 1;
            // 
            // RoomDescriptionLabel
            // 
            this.RoomDescriptionLabel.AutoEllipsis = true;
            this.RoomDescriptionLabel.AutoSize = true;
            this.RoomDescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomDescriptionLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomDescriptionLabel.Location = new System.Drawing.Point(11, 9);
            this.RoomDescriptionLabel.MaximumSize = new System.Drawing.Size(330, 0);
            this.RoomDescriptionLabel.Name = "RoomDescriptionLabel";
            this.RoomDescriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoomDescriptionLabel.Size = new System.Drawing.Size(310, 40);
            this.RoomDescriptionLabel.TabIndex = 0;
            this.RoomDescriptionLabel.Text = "Text Text Text Text Text Text Text Text Text Text Text Text Text ";
            // 
            // NorthButton
            // 
            this.NorthButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthButton.Location = new System.Drawing.Point(731, 165);
            this.NorthButton.Name = "NorthButton";
            this.NorthButton.Size = new System.Drawing.Size(87, 27);
            this.NorthButton.TabIndex = 2;
            this.NorthButton.Text = "North";
            this.NorthButton.UseVisualStyleBackColor = true;
            this.NorthButton.Click += new System.EventHandler(this.NorthButton_Click);
            // 
            // WestButton
            // 
            this.WestButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WestButton.Location = new System.Drawing.Point(516, 339);
            this.WestButton.Name = "WestButton";
            this.WestButton.Size = new System.Drawing.Size(87, 27);
            this.WestButton.TabIndex = 4;
            this.WestButton.Text = "West";
            this.WestButton.UseVisualStyleBackColor = true;
            this.WestButton.Click += new System.EventHandler(this.WestButton_Click);
            // 
            // SouthButton
            // 
            this.SouthButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthButton.Location = new System.Drawing.Point(731, 531);
            this.SouthButton.Name = "SouthButton";
            this.SouthButton.Size = new System.Drawing.Size(87, 27);
            this.SouthButton.TabIndex = 5;
            this.SouthButton.Text = "South";
            this.SouthButton.UseVisualStyleBackColor = true;
            this.SouthButton.Click += new System.EventHandler(this.SouthButton_Click);
            // 
            // EastButton
            // 
            this.EastButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EastButton.Location = new System.Drawing.Point(957, 339);
            this.EastButton.Name = "EastButton";
            this.EastButton.Size = new System.Drawing.Size(87, 27);
            this.EastButton.TabIndex = 6;
            this.EastButton.Text = "East";
            this.EastButton.UseVisualStyleBackColor = true;
            this.EastButton.Click += new System.EventHandler(this.EastButton_Click);
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.ItemHeight = 16;
            this.InventoryListBox.Location = new System.Drawing.Point(124, 433);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(272, 308);
            this.InventoryListBox.TabIndex = 7;
            // 
            // EquipButton
            // 
            this.EquipButton.Location = new System.Drawing.Point(163, 758);
            this.EquipButton.Name = "EquipButton";
            this.EquipButton.Size = new System.Drawing.Size(87, 27);
            this.EquipButton.TabIndex = 8;
            this.EquipButton.Text = "Equip";
            this.EquipButton.UseVisualStyleBackColor = true;
            this.EquipButton.Click += new System.EventHandler(this.EquipButton_Click);
            // 
            // EquippedWeaponTitleLabel
            // 
            this.EquippedWeaponTitleLabel.AutoSize = true;
            this.EquippedWeaponTitleLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquippedWeaponTitleLabel.Location = new System.Drawing.Point(121, 354);
            this.EquippedWeaponTitleLabel.Name = "EquippedWeaponTitleLabel";
            this.EquippedWeaponTitleLabel.Size = new System.Drawing.Size(129, 16);
            this.EquippedWeaponTitleLabel.TabIndex = 9;
            this.EquippedWeaponTitleLabel.Text = "Equipped Weapon";
            // 
            // EquippedWeaponLabel
            // 
            this.EquippedWeaponLabel.AutoSize = true;
            this.EquippedWeaponLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquippedWeaponLabel.Location = new System.Drawing.Point(121, 386);
            this.EquippedWeaponLabel.Name = "EquippedWeaponLabel";
            this.EquippedWeaponLabel.Size = new System.Drawing.Size(39, 16);
            this.EquippedWeaponLabel.TabIndex = 10;
            this.EquippedWeaponLabel.Text = "Null";
            // 
            // PlayerHealthLabel
            // 
            this.PlayerHealthLabel.AutoSize = true;
            this.PlayerHealthLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHealthLabel.Location = new System.Drawing.Point(121, 111);
            this.PlayerHealthLabel.Name = "PlayerHealthLabel";
            this.PlayerHealthLabel.Size = new System.Drawing.Size(81, 16);
            this.PlayerHealthLabel.TabIndex = 11;
            this.PlayerHealthLabel.Text = "Health: 15";
            // 
            // PlayerDamageLabel
            // 
            this.PlayerDamageLabel.AutoSize = true;
            this.PlayerDamageLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDamageLabel.Location = new System.Drawing.Point(121, 257);
            this.PlayerDamageLabel.Name = "PlayerDamageLabel";
            this.PlayerDamageLabel.Size = new System.Drawing.Size(81, 16);
            this.PlayerDamageLabel.TabIndex = 12;
            this.PlayerDamageLabel.Text = "Damage: 1";
            // 
            // PlayerManaLabel
            // 
            this.PlayerManaLabel.AutoSize = true;
            this.PlayerManaLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerManaLabel.Location = new System.Drawing.Point(121, 310);
            this.PlayerManaLabel.Name = "PlayerManaLabel";
            this.PlayerManaLabel.Size = new System.Drawing.Size(72, 16);
            this.PlayerManaLabel.TabIndex = 14;
            this.PlayerManaLabel.Text = "Mana: 10";
            // 
            // PlayerXAndYLabel
            // 
            this.PlayerXAndYLabel.AutoSize = true;
            this.PlayerXAndYLabel.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerXAndYLabel.Location = new System.Drawing.Point(746, 93);
            this.PlayerXAndYLabel.Name = "PlayerXAndYLabel";
            this.PlayerXAndYLabel.Size = new System.Drawing.Size(59, 15);
            this.PlayerXAndYLabel.TabIndex = 15;
            this.PlayerXAndYLabel.Text = "X: 0 Y: 0";
            // 
            // PlayerRoomLabel
            // 
            this.PlayerRoomLabel.AutoSize = true;
            this.PlayerRoomLabel.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerRoomLabel.Location = new System.Drawing.Point(684, 129);
            this.PlayerRoomLabel.Name = "PlayerRoomLabel";
            this.PlayerRoomLabel.Size = new System.Drawing.Size(194, 15);
            this.PlayerRoomLabel.TabIndex = 16;
            this.PlayerRoomLabel.Text = "Current Room:  Starting Room";
            // 
            // PlayerStatsLabel
            // 
            this.PlayerStatsLabel.AutoSize = true;
            this.PlayerStatsLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStatsLabel.Location = new System.Drawing.Point(121, 65);
            this.PlayerStatsLabel.Name = "PlayerStatsLabel";
            this.PlayerStatsLabel.Size = new System.Drawing.Size(106, 18);
            this.PlayerStatsLabel.TabIndex = 17;
            this.PlayerStatsLabel.Text = "Player Stats";
            // 
            // BattleBeginButton
            // 
            this.BattleBeginButton.Enabled = false;
            this.BattleBeginButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattleBeginButton.Location = new System.Drawing.Point(1193, 175);
            this.BattleBeginButton.Name = "BattleBeginButton";
            this.BattleBeginButton.Size = new System.Drawing.Size(87, 27);
            this.BattleBeginButton.TabIndex = 18;
            this.BattleBeginButton.Text = "Fight";
            this.BattleBeginButton.UseVisualStyleBackColor = true;
            this.BattleBeginButton.Visible = false;
            this.BattleBeginButton.Click += new System.EventHandler(this.BattleBeginButton_Click);
            // 
            // CombatPanel
            // 
            this.CombatPanel.Controls.Add(this.EnemyBurnedLabel);
            this.CombatPanel.Controls.Add(this.EnemyDamagedLabel);
            this.CombatPanel.Controls.Add(this.DamageTakenLabel);
            this.CombatPanel.Controls.Add(this.FailedEscapeLabel);
            this.CombatPanel.Controls.Add(this.CombatTextLabel);
            this.CombatPanel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombatPanel.Location = new System.Drawing.Point(1094, 266);
            this.CombatPanel.Name = "CombatPanel";
            this.CombatPanel.Size = new System.Drawing.Size(300, 300);
            this.CombatPanel.TabIndex = 19;
            // 
            // EnemyBurnedLabel
            // 
            this.EnemyBurnedLabel.AutoSize = true;
            this.EnemyBurnedLabel.Location = new System.Drawing.Point(70, 88);
            this.EnemyBurnedLabel.Name = "EnemyBurnedLabel";
            this.EnemyBurnedLabel.Size = new System.Drawing.Size(147, 16);
            this.EnemyBurnedLabel.TabIndex = 5;
            this.EnemyBurnedLabel.Text = "The enemy is burned!";
            this.EnemyBurnedLabel.Visible = false;
            // 
            // EnemyDamagedLabel
            // 
            this.EnemyDamagedLabel.AutoSize = true;
            this.EnemyDamagedLabel.Location = new System.Drawing.Point(44, 121);
            this.EnemyDamagedLabel.Name = "EnemyDamagedLabel";
            this.EnemyDamagedLabel.Size = new System.Drawing.Size(218, 16);
            this.EnemyDamagedLabel.TabIndex = 4;
            this.EnemyDamagedLabel.Text = "You hit the enemy for 5 damage!";
            this.EnemyDamagedLabel.Visible = false;
            // 
            // DamageTakenLabel
            // 
            this.DamageTakenLabel.AutoSize = true;
            this.DamageTakenLabel.Location = new System.Drawing.Point(60, 180);
            this.DamageTakenLabel.Name = "DamageTakenLabel";
            this.DamageTakenLabel.Size = new System.Drawing.Size(182, 16);
            this.DamageTakenLabel.TabIndex = 2;
            this.DamageTakenLabel.Text = "You were hit for 5 damage!";
            this.DamageTakenLabel.Visible = false;
            // 
            // FailedEscapeLabel
            // 
            this.FailedEscapeLabel.AutoSize = true;
            this.FailedEscapeLabel.Location = new System.Drawing.Point(83, 255);
            this.FailedEscapeLabel.Name = "FailedEscapeLabel";
            this.FailedEscapeLabel.Size = new System.Drawing.Size(134, 16);
            this.FailedEscapeLabel.TabIndex = 1;
            this.FailedEscapeLabel.Text = "You did not escape!";
            this.FailedEscapeLabel.Visible = false;
            // 
            // CombatTextLabel
            // 
            this.CombatTextLabel.AutoSize = true;
            this.CombatTextLabel.Location = new System.Drawing.Point(13, 11);
            this.CombatTextLabel.MaximumSize = new System.Drawing.Size(290, 0);
            this.CombatTextLabel.Name = "CombatTextLabel";
            this.CombatTextLabel.Size = new System.Drawing.Size(272, 48);
            this.CombatTextLabel.TabIndex = 0;
            this.CombatTextLabel.Text = "Text Text Text Text Text Text Text Text Text Text Text Text Text Text Text Text T" +
    "ext Text Text Text Text Text Text Text ";
            this.CombatTextLabel.Visible = false;
            // 
            // LevelUpPanel
            // 
            this.LevelUpPanel.Controls.Add(this.ExtraInfoLabel);
            this.LevelUpPanel.Controls.Add(this.FinishAllocationButton);
            this.LevelUpPanel.Controls.Add(this.SkillPointsLabel);
            this.LevelUpPanel.Controls.Add(this.IncreaseWisdomButton);
            this.LevelUpPanel.Controls.Add(this.IncreaseVitalityButton);
            this.LevelUpPanel.Controls.Add(this.IncreaseStrengthButton);
            this.LevelUpPanel.Controls.Add(this.PlayerWisdomLabel);
            this.LevelUpPanel.Controls.Add(this.PlayerVitalityLabel);
            this.LevelUpPanel.Controls.Add(this.PlayerStrengthLabel);
            this.LevelUpPanel.Location = new System.Drawing.Point(1110, 257);
            this.LevelUpPanel.Name = "LevelUpPanel";
            this.LevelUpPanel.Size = new System.Drawing.Size(266, 266);
            this.LevelUpPanel.TabIndex = 43;
            this.LevelUpPanel.Visible = false;
            // 
            // ExtraInfoLabel
            // 
            this.ExtraInfoLabel.AutoSize = true;
            this.ExtraInfoLabel.Location = new System.Drawing.Point(80, 231);
            this.ExtraInfoLabel.Name = "ExtraInfoLabel";
            this.ExtraInfoLabel.Size = new System.Drawing.Size(0, 15);
            this.ExtraInfoLabel.TabIndex = 8;
            // 
            // FinishAllocationButton
            // 
            this.FinishAllocationButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishAllocationButton.Location = new System.Drawing.Point(68, 196);
            this.FinishAllocationButton.Name = "FinishAllocationButton";
            this.FinishAllocationButton.Size = new System.Drawing.Size(124, 23);
            this.FinishAllocationButton.TabIndex = 7;
            this.FinishAllocationButton.Text = "Finish Allocation";
            this.FinishAllocationButton.UseVisualStyleBackColor = true;
            this.FinishAllocationButton.Click += new System.EventHandler(this.FinishAllocationButton_Click);
            // 
            // SkillPointsLabel
            // 
            this.SkillPointsLabel.AutoSize = true;
            this.SkillPointsLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillPointsLabel.Location = new System.Drawing.Point(80, 14);
            this.SkillPointsLabel.Name = "SkillPointsLabel";
            this.SkillPointsLabel.Size = new System.Drawing.Size(108, 16);
            this.SkillPointsLabel.TabIndex = 6;
            this.SkillPointsLabel.Text = "Skill Points: 0";
            // 
            // IncreaseWisdomButton
            // 
            this.IncreaseWisdomButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncreaseWisdomButton.Location = new System.Drawing.Point(6, 158);
            this.IncreaseWisdomButton.Name = "IncreaseWisdomButton";
            this.IncreaseWisdomButton.Size = new System.Drawing.Size(124, 32);
            this.IncreaseWisdomButton.TabIndex = 5;
            this.IncreaseWisdomButton.Text = "+1 Wisdom 1 SP";
            this.IncreaseWisdomButton.UseVisualStyleBackColor = true;
            this.IncreaseWisdomButton.Click += new System.EventHandler(this.IncreaseWisdomButton_Click);
            // 
            // IncreaseVitalityButton
            // 
            this.IncreaseVitalityButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncreaseVitalityButton.Location = new System.Drawing.Point(6, 100);
            this.IncreaseVitalityButton.Name = "IncreaseVitalityButton";
            this.IncreaseVitalityButton.Size = new System.Drawing.Size(124, 31);
            this.IncreaseVitalityButton.TabIndex = 4;
            this.IncreaseVitalityButton.Text = "+1 Vitality 1 SP";
            this.IncreaseVitalityButton.UseVisualStyleBackColor = true;
            this.IncreaseVitalityButton.Click += new System.EventHandler(this.IncreaseVitalityButton_Click);
            // 
            // IncreaseStrengthButton
            // 
            this.IncreaseStrengthButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncreaseStrengthButton.Location = new System.Drawing.Point(6, 46);
            this.IncreaseStrengthButton.Name = "IncreaseStrengthButton";
            this.IncreaseStrengthButton.Size = new System.Drawing.Size(124, 31);
            this.IncreaseStrengthButton.TabIndex = 3;
            this.IncreaseStrengthButton.Text = "+1 Strength 2 SP";
            this.IncreaseStrengthButton.UseVisualStyleBackColor = true;
            this.IncreaseStrengthButton.Click += new System.EventHandler(this.IncreaseStrengthButton_Click);
            // 
            // PlayerWisdomLabel
            // 
            this.PlayerWisdomLabel.AutoSize = true;
            this.PlayerWisdomLabel.Location = new System.Drawing.Point(134, 167);
            this.PlayerWisdomLabel.Name = "PlayerWisdomLabel";
            this.PlayerWisdomLabel.Size = new System.Drawing.Size(60, 15);
            this.PlayerWisdomLabel.TabIndex = 2;
            this.PlayerWisdomLabel.Text = "Wisdom: 1";
            // 
            // PlayerVitalityLabel
            // 
            this.PlayerVitalityLabel.AutoSize = true;
            this.PlayerVitalityLabel.Location = new System.Drawing.Point(133, 108);
            this.PlayerVitalityLabel.Name = "PlayerVitalityLabel";
            this.PlayerVitalityLabel.Size = new System.Drawing.Size(56, 15);
            this.PlayerVitalityLabel.TabIndex = 1;
            this.PlayerVitalityLabel.Text = "Vitality: 1";
            // 
            // PlayerStrengthLabel
            // 
            this.PlayerStrengthLabel.AutoSize = true;
            this.PlayerStrengthLabel.Location = new System.Drawing.Point(133, 49);
            this.PlayerStrengthLabel.Name = "PlayerStrengthLabel";
            this.PlayerStrengthLabel.Size = new System.Drawing.Size(65, 15);
            this.PlayerStrengthLabel.TabIndex = 0;
            this.PlayerStrengthLabel.Text = "Strength: 1";
            // 
            // EnemyNameLabel
            // 
            this.EnemyNameLabel.AutoSize = true;
            this.EnemyNameLabel.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyNameLabel.Location = new System.Drawing.Point(1185, 181);
            this.EnemyNameLabel.Name = "EnemyNameLabel";
            this.EnemyNameLabel.Size = new System.Drawing.Size(61, 15);
            this.EnemyNameLabel.TabIndex = 0;
            this.EnemyNameLabel.Text = "Monster:";
            this.EnemyNameLabel.Visible = false;
            // 
            // EnemyStatsLabel
            // 
            this.EnemyStatsLabel.AutoSize = true;
            this.EnemyStatsLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyStatsLabel.Location = new System.Drawing.Point(1184, 152);
            this.EnemyStatsLabel.Name = "EnemyStatsLabel";
            this.EnemyStatsLabel.Size = new System.Drawing.Size(125, 20);
            this.EnemyStatsLabel.TabIndex = 20;
            this.EnemyStatsLabel.Text = "Monster Stats";
            this.EnemyStatsLabel.Visible = false;
            // 
            // EnemyDamageLabel
            // 
            this.EnemyDamageLabel.AutoSize = true;
            this.EnemyDamageLabel.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyDamageLabel.Location = new System.Drawing.Point(1185, 232);
            this.EnemyDamageLabel.Name = "EnemyDamageLabel";
            this.EnemyDamageLabel.Size = new System.Drawing.Size(70, 15);
            this.EnemyDamageLabel.TabIndex = 22;
            this.EnemyDamageLabel.Text = "Damage: 1";
            this.EnemyDamageLabel.Visible = false;
            // 
            // EnemyHealthLabel
            // 
            this.EnemyHealthLabel.AutoSize = true;
            this.EnemyHealthLabel.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHealthLabel.Location = new System.Drawing.Point(1185, 206);
            this.EnemyHealthLabel.Name = "EnemyHealthLabel";
            this.EnemyHealthLabel.Size = new System.Drawing.Size(74, 15);
            this.EnemyHealthLabel.TabIndex = 23;
            this.EnemyHealthLabel.Text = "Health: 5/5";
            this.EnemyHealthLabel.Visible = false;
            // 
            // InventoryTitleLabel
            // 
            this.InventoryTitleLabel.AutoSize = true;
            this.InventoryTitleLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryTitleLabel.Location = new System.Drawing.Point(205, 404);
            this.InventoryTitleLabel.Name = "InventoryTitleLabel";
            this.InventoryTitleLabel.Size = new System.Drawing.Size(92, 20);
            this.InventoryTitleLabel.TabIndex = 24;
            this.InventoryTitleLabel.Text = "Inventory";
            // 
            // UseItemButton
            // 
            this.UseItemButton.AutoSize = true;
            this.UseItemButton.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseItemButton.Location = new System.Drawing.Point(1246, 572);
            this.UseItemButton.Name = "UseItemButton";
            this.UseItemButton.Size = new System.Drawing.Size(65, 27);
            this.UseItemButton.TabIndex = 25;
            this.UseItemButton.Text = "Use Item";
            this.UseItemButton.UseVisualStyleBackColor = true;
            this.UseItemButton.Visible = false;
            this.UseItemButton.Click += new System.EventHandler(this.UseItemButton_Click);
            // 
            // AttackButton
            // 
            this.AttackButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackButton.Location = new System.Drawing.Point(1110, 572);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(62, 27);
            this.AttackButton.TabIndex = 26;
            this.AttackButton.Text = "Attack";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Visible = false;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(1314, 572);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(62, 27);
            this.RunButton.TabIndex = 27;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Visible = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MagicButton
            // 
            this.MagicButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagicButton.Location = new System.Drawing.Point(1178, 572);
            this.MagicButton.Name = "MagicButton";
            this.MagicButton.Size = new System.Drawing.Size(62, 27);
            this.MagicButton.TabIndex = 28;
            this.MagicButton.Text = "Magic";
            this.MagicButton.UseVisualStyleBackColor = true;
            this.MagicButton.Visible = false;
            this.MagicButton.Click += new System.EventHandler(this.MagicButton_Click);
            // 
            // RestButton
            // 
            this.RestButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestButton.Location = new System.Drawing.Point(731, 641);
            this.RestButton.Name = "RestButton";
            this.RestButton.Size = new System.Drawing.Size(87, 27);
            this.RestButton.TabIndex = 30;
            this.RestButton.Text = "Rest";
            this.RestButton.UseVisualStyleBackColor = true;
            this.RestButton.Click += new System.EventHandler(this.RestButton_Click);
            // 
            // PlayerLeveLLabel
            // 
            this.PlayerLeveLLabel.AutoSize = true;
            this.PlayerLeveLLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLeveLLabel.Location = new System.Drawing.Point(121, 165);
            this.PlayerLeveLLabel.Name = "PlayerLeveLLabel";
            this.PlayerLeveLLabel.Size = new System.Drawing.Size(63, 16);
            this.PlayerLeveLLabel.TabIndex = 31;
            this.PlayerLeveLLabel.Text = "Level: 1";
            // 
            // PlayerXPLabel
            // 
            this.PlayerXPLabel.AutoSize = true;
            this.PlayerXPLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerXPLabel.Location = new System.Drawing.Point(121, 210);
            this.PlayerXPLabel.Name = "PlayerXPLabel";
            this.PlayerXPLabel.Size = new System.Drawing.Size(46, 16);
            this.PlayerXPLabel.TabIndex = 32;
            this.PlayerXPLabel.Text = "XP: 0";
            // 
            // OpenChestButton
            // 
            this.OpenChestButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenChestButton.Location = new System.Drawing.Point(731, 587);
            this.OpenChestButton.Name = "OpenChestButton";
            this.OpenChestButton.Size = new System.Drawing.Size(87, 27);
            this.OpenChestButton.TabIndex = 34;
            this.OpenChestButton.Text = "Open Chest";
            this.OpenChestButton.UseVisualStyleBackColor = true;
            this.OpenChestButton.Visible = false;
            this.OpenChestButton.Click += new System.EventHandler(this.OpenChestButton_Click);
            // 
            // PlayerSpellsListBox
            // 
            this.PlayerSpellsListBox.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSpellsListBox.FormattingEnabled = true;
            this.PlayerSpellsListBox.ItemHeight = 15;
            this.PlayerSpellsListBox.Location = new System.Drawing.Point(1131, 605);
            this.PlayerSpellsListBox.Name = "PlayerSpellsListBox";
            this.PlayerSpellsListBox.Size = new System.Drawing.Size(225, 169);
            this.PlayerSpellsListBox.TabIndex = 35;
            this.PlayerSpellsListBox.Visible = false;
            // 
            // CastSpellButton
            // 
            this.CastSpellButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CastSpellButton.Location = new System.Drawing.Point(1218, 791);
            this.CastSpellButton.Name = "CastSpellButton";
            this.CastSpellButton.Size = new System.Drawing.Size(62, 27);
            this.CastSpellButton.TabIndex = 36;
            this.CastSpellButton.Text = "Cast";
            this.CastSpellButton.UseVisualStyleBackColor = true;
            this.CastSpellButton.Visible = false;
            this.CastSpellButton.Click += new System.EventHandler(this.CastSpellButton_Click);
            // 
            // CurrentQuestLabel
            // 
            this.CurrentQuestLabel.AutoSize = true;
            this.CurrentQuestLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentQuestLabel.Location = new System.Drawing.Point(72, 7);
            this.CurrentQuestLabel.Name = "CurrentQuestLabel";
            this.CurrentQuestLabel.Size = new System.Drawing.Size(124, 18);
            this.CurrentQuestLabel.TabIndex = 37;
            this.CurrentQuestLabel.Text = "Current Quest";
            // 
            // CurrentQuestDescriptionLabel
            // 
            this.CurrentQuestDescriptionLabel.AutoSize = true;
            this.CurrentQuestDescriptionLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentQuestDescriptionLabel.Location = new System.Drawing.Point(17, 45);
            this.CurrentQuestDescriptionLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.CurrentQuestDescriptionLabel.Name = "CurrentQuestDescriptionLabel";
            this.CurrentQuestDescriptionLabel.Size = new System.Drawing.Size(224, 48);
            this.CurrentQuestDescriptionLabel.TabIndex = 38;
            this.CurrentQuestDescriptionLabel.Text = "Text Text Text Text Text Text Text Text Text Text Text Text Text Text Text ";
            // 
            // CurrentQuestPanel
            // 
            this.CurrentQuestPanel.Controls.Add(this.QuestRewardLabel);
            this.CurrentQuestPanel.Controls.Add(this.CurrentQuestLabel);
            this.CurrentQuestPanel.Controls.Add(this.CurrentQuestDescriptionLabel);
            this.CurrentQuestPanel.Location = new System.Drawing.Point(315, 83);
            this.CurrentQuestPanel.Name = "CurrentQuestPanel";
            this.CurrentQuestPanel.Size = new System.Drawing.Size(244, 206);
            this.CurrentQuestPanel.TabIndex = 39;
            // 
            // QuestRewardLabel
            // 
            this.QuestRewardLabel.AutoSize = true;
            this.QuestRewardLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestRewardLabel.Location = new System.Drawing.Point(17, 103);
            this.QuestRewardLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.QuestRewardLabel.Name = "QuestRewardLabel";
            this.QuestRewardLabel.Size = new System.Drawing.Size(114, 16);
            this.QuestRewardLabel.TabIndex = 39;
            this.QuestRewardLabel.Text = "Reward: 100 xp";
            // 
            // AcceptQuestButton
            // 
            this.AcceptQuestButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptQuestButton.Location = new System.Drawing.Point(731, 694);
            this.AcceptQuestButton.Name = "AcceptQuestButton";
            this.AcceptQuestButton.Size = new System.Drawing.Size(90, 23);
            this.AcceptQuestButton.TabIndex = 40;
            this.AcceptQuestButton.Text = "Start Quest";
            this.AcceptQuestButton.UseVisualStyleBackColor = true;
            this.AcceptQuestButton.Click += new System.EventHandler(this.AcceptQuestButton_Click);
            // 
            // CompleteQuestButton
            // 
            this.CompleteQuestButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteQuestButton.Location = new System.Drawing.Point(722, 736);
            this.CompleteQuestButton.Name = "CompleteQuestButton";
            this.CompleteQuestButton.Size = new System.Drawing.Size(111, 38);
            this.CompleteQuestButton.TabIndex = 41;
            this.CompleteQuestButton.Text = "Complete Quest";
            this.CompleteQuestButton.UseVisualStyleBackColor = true;
            this.CompleteQuestButton.Visible = false;
            this.CompleteQuestButton.Click += new System.EventHandler(this.CompleteQuestButton_Click);
            // 
            // UseInventoryItemButton
            // 
            this.UseInventoryItemButton.Location = new System.Drawing.Point(265, 758);
            this.UseInventoryItemButton.Name = "UseInventoryItemButton";
            this.UseInventoryItemButton.Size = new System.Drawing.Size(87, 27);
            this.UseInventoryItemButton.TabIndex = 42;
            this.UseInventoryItemButton.Text = "Use";
            this.UseInventoryItemButton.UseVisualStyleBackColor = true;
            this.UseInventoryItemButton.Click += new System.EventHandler(this.UseInventoryItemButton_Click);
            // 
            // GoUpButton
            // 
            this.GoUpButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoUpButton.Location = new System.Drawing.Point(111, 255);
            this.GoUpButton.Name = "GoUpButton";
            this.GoUpButton.Size = new System.Drawing.Size(102, 50);
            this.GoUpButton.TabIndex = 44;
            this.GoUpButton.Text = "Go Up A Floor";
            this.GoUpButton.UseVisualStyleBackColor = true;
            this.GoUpButton.Click += new System.EventHandler(this.GoUpButton_Click);
            // 
            // PlayerFloorLabel
            // 
            this.PlayerFloorLabel.AutoSize = true;
            this.PlayerFloorLabel.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerFloorLabel.Location = new System.Drawing.Point(750, 111);
            this.PlayerFloorLabel.Name = "PlayerFloorLabel";
            this.PlayerFloorLabel.Size = new System.Drawing.Size(54, 15);
            this.PlayerFloorLabel.TabIndex = 44;
            this.PlayerFloorLabel.Text = "Floor: 1";
            // 
            // GoDownButton
            // 
            this.GoDownButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoDownButton.Location = new System.Drawing.Point(111, 255);
            this.GoDownButton.Name = "GoDownButton";
            this.GoDownButton.Size = new System.Drawing.Size(102, 50);
            this.GoDownButton.TabIndex = 45;
            this.GoDownButton.Text = "Go Down A Floor";
            this.GoDownButton.UseVisualStyleBackColor = true;
            this.GoDownButton.Visible = false;
            this.GoDownButton.Click += new System.EventHandler(this.GoDownButton_Click);
            // 
            // DarksReachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 820);
            this.Controls.Add(this.PlayerFloorLabel);
            this.Controls.Add(this.LevelUpPanel);
            this.Controls.Add(this.UseInventoryItemButton);
            this.Controls.Add(this.CompleteQuestButton);
            this.Controls.Add(this.AcceptQuestButton);
            this.Controls.Add(this.CurrentQuestPanel);
            this.Controls.Add(this.CastSpellButton);
            this.Controls.Add(this.PlayerSpellsListBox);
            this.Controls.Add(this.OpenChestButton);
            this.Controls.Add(this.PlayerXPLabel);
            this.Controls.Add(this.PlayerLeveLLabel);
            this.Controls.Add(this.RestButton);
            this.Controls.Add(this.MagicButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.UseItemButton);
            this.Controls.Add(this.InventoryTitleLabel);
            this.Controls.Add(this.EnemyHealthLabel);
            this.Controls.Add(this.EnemyDamageLabel);
            this.Controls.Add(this.EnemyStatsLabel);
            this.Controls.Add(this.EnemyNameLabel);
            this.Controls.Add(this.CombatPanel);
            this.Controls.Add(this.BattleBeginButton);
            this.Controls.Add(this.PlayerStatsLabel);
            this.Controls.Add(this.PlayerRoomLabel);
            this.Controls.Add(this.PlayerXAndYLabel);
            this.Controls.Add(this.PlayerManaLabel);
            this.Controls.Add(this.PlayerDamageLabel);
            this.Controls.Add(this.PlayerHealthLabel);
            this.Controls.Add(this.EquippedWeaponLabel);
            this.Controls.Add(this.EquippedWeaponTitleLabel);
            this.Controls.Add(this.EquipButton);
            this.Controls.Add(this.InventoryListBox);
            this.Controls.Add(this.EastButton);
            this.Controls.Add(this.SouthButton);
            this.Controls.Add(this.WestButton);
            this.Controls.Add(this.NorthButton);
            this.Controls.Add(this.MapPanel);
            this.Controls.Add(this.DarksReachTopLabel);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DarksReachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dark\'s Reach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DarksReachForm_FormClosing);
            this.MapPanel.ResumeLayout(false);
            this.MapPanel.PerformLayout();
            this.CombatPanel.ResumeLayout(false);
            this.CombatPanel.PerformLayout();
            this.LevelUpPanel.ResumeLayout(false);
            this.LevelUpPanel.PerformLayout();
            this.CurrentQuestPanel.ResumeLayout(false);
            this.CurrentQuestPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DarksReachTopLabel;
        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.Button NorthButton;
        private System.Windows.Forms.Button WestButton;
        private System.Windows.Forms.Button SouthButton;
        private System.Windows.Forms.Button EastButton;
        private System.Windows.Forms.ListBox InventoryListBox;
        private System.Windows.Forms.Button EquipButton;
        private System.Windows.Forms.Label EquippedWeaponTitleLabel;
        private System.Windows.Forms.Label EquippedWeaponLabel;
        private System.Windows.Forms.Label PlayerHealthLabel;
        private System.Windows.Forms.Label PlayerDamageLabel;
        private System.Windows.Forms.Label PlayerManaLabel;
        private System.Windows.Forms.Label PlayerXAndYLabel;
        private System.Windows.Forms.Label PlayerRoomLabel;
        private System.Windows.Forms.Label RoomDescriptionLabel;
        private System.Windows.Forms.Label PlayerStatsLabel;
        private System.Windows.Forms.Button BattleBeginButton;
        private System.Windows.Forms.Panel CombatPanel;
        private System.Windows.Forms.Label EnemyNameLabel;
        private System.Windows.Forms.Label EnemyStatsLabel;
        private System.Windows.Forms.Label EnemyDamageLabel;
        private System.Windows.Forms.Label EnemyHealthLabel;
        private System.Windows.Forms.Label InventoryTitleLabel;
        private System.Windows.Forms.Button UseItemButton;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button MagicButton;
        private System.Windows.Forms.Label CombatTextLabel;
        private System.Windows.Forms.Label FailedEscapeLabel;
        private System.Windows.Forms.Label DamageTakenLabel;
        private System.Windows.Forms.Label EnemyDamagedLabel;
        private System.Windows.Forms.Button RestButton;
        private System.Windows.Forms.Label PlayerLeveLLabel;
        private System.Windows.Forms.Label PlayerXPLabel;
        private System.Windows.Forms.Button OpenChestButton;
        private System.Windows.Forms.ListBox PlayerSpellsListBox;
        private System.Windows.Forms.Button CastSpellButton;
        private System.Windows.Forms.Label CurrentQuestLabel;
        private System.Windows.Forms.Label CurrentQuestDescriptionLabel;
        private System.Windows.Forms.Panel CurrentQuestPanel;
        private System.Windows.Forms.Label QuestRewardLabel;
        private System.Windows.Forms.Button AcceptQuestButton;
        private System.Windows.Forms.Button CompleteQuestButton;
        private System.Windows.Forms.Button UseInventoryItemButton;
        private System.Windows.Forms.Label EnemyBurnedLabel;
        private System.Windows.Forms.Panel LevelUpPanel;
        private System.Windows.Forms.Button IncreaseWisdomButton;
        private System.Windows.Forms.Button IncreaseVitalityButton;
        private System.Windows.Forms.Button IncreaseStrengthButton;
        private System.Windows.Forms.Label PlayerWisdomLabel;
        private System.Windows.Forms.Label PlayerVitalityLabel;
        private System.Windows.Forms.Label PlayerStrengthLabel;
        private System.Windows.Forms.Label SkillPointsLabel;
        private System.Windows.Forms.Button FinishAllocationButton;
        private System.Windows.Forms.Label ExtraInfoLabel;
        private System.Windows.Forms.Button GoUpButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label PlayerFloorLabel;
        private System.Windows.Forms.Button GoDownButton;
    }
}

