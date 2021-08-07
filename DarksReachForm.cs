using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarksReachRemake;
using DarksReachRemake.Items;
using DarksReachRemake.Movement;
using DarksReachRemake.Movement.Rooms;
using DarksReachRemake.Entities;
using DarksReachRemake.Magic;
using DarksReachRemake.Quests;
namespace DarksReachRemake
{
    public partial class 
        DarksReachForm : Form
    {
        public static BindingSource inventoryBinding = new BindingSource();
        public static BindingSource spellsBinding = new BindingSource();
        public static bool SelectingSpell { get; set; }
        public static Random rand = new Random();
        public string version = "v0.6.0.2"; //major update . new feature(magic/combat/chests/etc) . new item/enemy/room/quest . bug fixes
        public Button lastClicked { get; set; }


        Monster foughtMonster;
        public DarksReachForm()
        {
            InitializeComponent();
            this.Text = "Dark's Reach " + version;
            SetItems.SetDefaults();
            SetSpells.SetDefaults();
            SetEntities.SetDefaults();
            SetRooms.SetDefaults();
            SetQuests.SetDefaults();
            Program.player.reset();
            UpdateGame();
            inventoryBinding.DataSource = Program.player.Inventory;
            InventoryListBox.DataSource = inventoryBinding;
            InventoryListBox.DisplayMember = "Display";
            InventoryListBox.ValueMember = "Display";
            spellsBinding.DataSource = Program.player.spellBook;
            PlayerSpellsListBox.DataSource = spellsBinding;
            PlayerSpellsListBox.DisplayMember = "Display";
            PlayerSpellsListBox.ValueMember = "Display";
            MapPanel.BackColor = Color.BlanchedAlmond;
            CombatPanel.BackColor = Color.BlanchedAlmond;

        }
        public void UpdateGame()
        {
            if(Program.player.health <= 0)
            {
                Program.player.alive = false;
                MessageBox.Show("You have been killed. Thanks for playing!");
                this.Close();
            }
            //Set All Default Labels
            Program.player.Update();
            SetRooms.SetDefaults();
            SetQuests.SetDefaults();
            PlayerFloorLabel.Text = "Floor: " + Program.player.z;
            EquippedWeaponLabel.Text = Program.player.equippedWeapon.name;
            PlayerHealthLabel.Text = Program.player.name + "'s Health: " + Program.player.health.ToString() + "/" + Program.player.maxHealth.ToString();
            PlayerDamageLabel.Text = Program.player.name + "'s Base Damage: " + Program.player.totalDamage;
            PlayerManaLabel.Text = Program.player.name + "'s Mana: " + Program.player.mana.ToString() + "/" + Program.player.maxMana.ToString();
            PlayerXAndYLabel.Text = "X: " + Program.player.x + " Y: " + Program.player.y;
            PlayerXPLabel.Text = "XP: " + Program.player.xp;
            PlayerLeveLLabel.Text = "Level: " + Program.player.Level;
            PlayerRoomLabel.Text = "Current Room: " + Program.player.Location.name;
            PlayerStrengthLabel.Text = "Strength: " + Program.player.strength;
            PlayerVitalityLabel.Text = "Vitality: " + Program.player.vitality;
            PlayerWisdomLabel.Text = "Wisdom: " + Program.player.wisdom;
            SkillPointsLabel.Text = "Skill Points: " + Program.player.SkillPoints;
            RoomDescriptionLabel.Text = "Room Description: " + Program.player.Location.description;
            inventoryBinding.ResetBindings(false);
            spellsBinding.ResetBindings(false);
            if (Program.player.currentQuest == SetQuests.FindChild && Program.player.Location == Program.player.currentQuest.finalDestination)
            {
                CompleteQuestButton.Visible = true;
                CompleteQuestButton.Text = "Confront Child";
            }else
            {
                CompleteQuestButton.Visible = false;
            }

            if (Program.player.Location == SetRooms.SpaceRoom)
                {
                    AcceptQuestButton.Visible = true;
                }else
                {
                    AcceptQuestButton.Visible = false;
                }
            if (Program.player.currentQuest == null)
            {
                CurrentQuestPanel.Visible = false;

            }
            else
            {
                CurrentQuestPanel.Visible = true;
                CurrentQuestLabel.Text = Program.player.currentQuest.questName;
                CurrentQuestDescriptionLabel.Text = Program.player.currentQuest.questDescription;
                QuestRewardLabel.Text = "Reward: " + Program.player.currentQuest.xpGained + " xp";
            }
            if (Program.player.Location.monsters.Count > 0 && Program.player.Location.deadRoom == false)
            {
                Program.player.monsteredRoom = true;
            }
            else
            {
                Program.player.monsteredRoom = false;
            }
            if (Program.player.monsteredRoom == true)
            {
                BattleBeginButton.Visible = true;
                BattleBeginButton.Enabled = true; 
            }else
            {
                BattleBeginButton.Visible = false;
                BattleBeginButton.Enabled = false;
            }
            if (Battling())
            {
                //Disable Unrelated Controls
                BattleBeginButton.Visible = false;
                BattleBeginButton.Enabled = false;

                RestButton.Enabled = false;

                EquipButton.Enabled = false;

                WestButton.Enabled = false;

                NorthButton.Enabled = false;

                EastButton.Enabled = false;

                SouthButton.Enabled = false;

                UseInventoryItemButton.Enabled = false;

                GoUpButton.Enabled = false;
                GoDownButton.Enabled = false;
                //Enable Combat Related Controls

                EnemyNameLabel.Visible = true;
                EnemyNameLabel.Enabled = true;
                EnemyNameLabel.Text = "Monster: " + Combat.foughtMonster.name;
                CombatTextLabel.Text = "You have begun combat with a " + Combat.foughtMonster.name + "! What do you do?";

                CombatPanel.Visible = true;
                CombatPanel.Enabled = true;

                EnemyDamageLabel.Visible = true;

                EnemyStatsLabel.Visible = true;

                EnemyHealthLabel.Visible = true;

                EnemyNameLabel.Visible = true;

                UseItemButton.Visible = true;

                AttackButton.Visible = true;

                MagicButton.Visible = true;

                RunButton.Visible = true;

                CombatTextLabel.Visible = true;

                EnemyDamageLabel.Text = "Base Damage: " + Combat.foughtMonster.damage;

                EnemyHealthLabel.Text = "Health: " + Combat.foughtMonster.health + "/" + Combat.foughtMonster.maxHealth;

                EnemyNameLabel.Text = "Monster: " + Combat.foughtMonster.name;

                if (Combat.playerAttacked == true)
                {
                    DamageTakenLabel.Text = "You were hit for " + Combat.totalEnemyDamage + " damage!";
                    DamageTakenLabel.Visible = true;
                }
                else
                {
                    DamageTakenLabel.Visible = false;
                }

                if (lastClicked == RunButton)
                {
                    if (Combat.runSucceed == true)
                    {
                        FailedEscapeLabel.Visible = false;
                    }
                    else
                    {
                        FailedEscapeLabel.Visible = true;
                    }
                }else
                {
                    FailedEscapeLabel.Visible = false;
                }
                if(lastClicked == AttackButton)
                {
                    if (Combat.enemyAttacked == true)
                    {
                        EnemyDamagedLabel.Visible = true;
                        EnemyDamagedLabel.Text = "You hit the enemy for " + Combat.totalPlayerDamage +" damage!";
                    }
                    else
                    {
                        EnemyDamagedLabel.Visible = false;
                    }
                }else
                {
                    EnemyDamagedLabel.Visible = false;
                }
                if (SelectingSpell == true)
                {
                    PlayerSpellsListBox.Visible = true;
                    CastSpellButton.Visible = true;
                }
                else
                {
                    PlayerSpellsListBox.Visible = false;
                    CastSpellButton.Visible = false;
                }
                if (Combat.foughtMonster.burned)
                {
                    EnemyBurnedLabel.Visible = true;
                }else
                {
                    EnemyBurnedLabel.Visible = false;
                }
            }
            else
            {
                //Reenable all Unrelated Controls
                EquipButton.Enabled = true;

                WestButton.Enabled = true;

                NorthButton.Enabled = true;

                EastButton.Enabled = true;

                SouthButton.Enabled = true;

                RestButton.Enabled = true;

                GoUpButton.Enabled = true;

                GoDownButton.Enabled = true;

                UseInventoryItemButton.Enabled = true;
                //Disable all Combat Related Controls

                EnemyNameLabel.Enabled = false;
                EnemyNameLabel.Visible = false;
                
                CombatPanel.Visible = false;
                CombatPanel.Enabled = false;

                EnemyDamageLabel.Visible = false;

                EnemyStatsLabel.Visible = false;

                EnemyHealthLabel.Visible = false;

                EnemyNameLabel.Visible = false;

                UseItemButton.Visible = false;

                AttackButton.Visible = false;

                MagicButton.Visible = false;

                RunButton.Visible = false;

                PlayerSpellsListBox.Visible = false;

                CastSpellButton.Visible = false;

                SelectingSpell = false;
            }
            if (Program.player.Location.chest != null && Program.player.Location.chest.used != true)
            {
                OpenChestButton.Visible = true;
            }
            else
            {
                OpenChestButton.Visible = false;
            }
            if (Program.player.levelingUp == true)
            {
                //Disable all unrelated Controls
                BattleBeginButton.Enabled = false;

                RestButton.Enabled = false;

                EquipButton.Enabled = false;

                WestButton.Enabled = false;

                NorthButton.Enabled = false;

                EastButton.Enabled = false;

                SouthButton.Enabled = false;

                UseInventoryItemButton.Enabled = false;

                if (Program.player.Level == 3)
                {
                    ExtraInfoLabel.Text = "You learned Burn!";
                }else
                {
                    ExtraInfoLabel.Text = "";
                }

                LevelUpPanel.Visible = true;

            }
            else
            {
                LevelUpPanel.Visible = false;
            }
            if (Program.player.Location.canGoUp)
            {
                GoUpButton.Visible = true;

            }else
            {
                GoUpButton.Visible = false;
            }
            if (Program.player.Location.canGoDown)
            {
                GoDownButton.Visible = true;

            }
            else
            {
                GoDownButton.Visible = false;
            }
        }






        private void EquipButton_Click(object sender, EventArgs e)
        {
            
            Program.player.Inventory[InventoryListBox.SelectedIndex].equip();
            EquippedWeaponLabel.Text = Program.player.equippedWeapon.name;
            Program.player.Update();
            UpdateGame();
        }

        private void EastButton_Click(object sender, EventArgs e)
        {

            Program.player.Move(Movement.Location.Direction.East);
            UpdateGame();

        }

        private void NorthButton_Click(object sender, EventArgs e)
        {
            Program.player.Move(Movement.Location.Direction.North);

            UpdateGame();

        }

        private void WestButton_Click(object sender, EventArgs e)
        {
            Program.player.Move(Movement.Location.Direction.West);
            UpdateGame();

        }

        private void SouthButton_Click(object sender, EventArgs e)
        {
            Program.player.Move(Movement.Location.Direction.South);
            UpdateGame();
        }


        private void BattleBeginButton_Click(object sender, EventArgs e)
        {
            foughtMonster = Program.player.Location.monsters[rand.Next(0, Program.player.Location.monsters.Count)];
            Combat.foughtMonster = foughtMonster;
            Combat.Begin(foughtMonster, Program.player);
            UpdateGame();
        }
        bool Battling()
        {
            while(Combat.running == true)
            {
                return true;
            }
            return false;
        }

        private void UseItemButton_Click(object sender, EventArgs e)
        {
            lastClicked = UseItemButton;
            if (Program.player.Inventory[InventoryListBox.SelectedIndex].weapon)
            {
                MessageBox.Show("You can not equip a weapon during combat.");
            }else if(Program.player.Inventory[InventoryListBox.SelectedIndex].potion)
            {
                if(Program.player.health == Program.player.maxHealth)
                {
                    MessageBox.Show("You already have maximum health!");
                }else
                {
                    Program.player.HealHealth(Program.player.Inventory[InventoryListBox.SelectedIndex].healingAmount);
                    Program.player.RemoveItem(Program.player.Inventory[InventoryListBox.SelectedIndex]);
                }
            }else
            {
                MessageBox.Show("You can not use this item.");
            }
            UpdateGame();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
                lastClicked = RunButton;
                Combat.Run(Combat.foughtMonster, Program.player);
            
            UpdateGame();
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            lastClicked = AttackButton;
            Combat.Attack(Combat.foughtMonster, Program.player);
            UpdateGame();
        }

        private void RestButton_Click(object sender, EventArgs e)
        {
            if (rand.Next(0, 4) != 0){
                Program.player.FullyHeal();
            }else
            {
                Combat.Begin(SetEntities.Nightmare, Program.player);

            }
            UpdateGame();
        }

        private void OpenChestButton_Click(object sender, EventArgs e)
        {
            if (!Program.player.Location.chest.used)
            {
                Program.player.Location.chest.Open();
            }
            UpdateGame();
        }

        private void MagicButton_Click(object sender, EventArgs e)
        {
            SelectingSpell = true;
            
            UpdateGame();
        }

        private void CastSpellButton_Click(object sender, EventArgs e)
        {
            SelectingSpell = false;

            Program.player.spellBook[PlayerSpellsListBox.SelectedIndex].Cast(Program.player, Combat.foughtMonster);
            UpdateGame();
        }

        private void AcceptQuestButton_Click(object sender, EventArgs e)
        {
            if (Program.player.Location == SetRooms.SpaceRoom)
            {
                SetQuests.FindChild.GiveQuest(Program.player);
            }
            UpdateGame();
        }

        private void DarksReachForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Program.player.alive)
            {
                if (MessageBox.Show("Are you sure you want to close the game? All progress will be lost!", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }else
            {
                
                
            }


        }

        private void CompleteQuestButton_Click(object sender, EventArgs e)
        {
            if(Program.player.currentQuest == SetQuests.FindChild && Program.player.Location == SetQuests.FindChild.finalDestination)
            {
                Program.player.currentQuest.Complete(Program.player);
            }else
            {
                MessageBox.Show("Please report that you are seeing this.", "Error");
            }
            UpdateGame();
        }

        private void UseInventoryItemButton_Click(object sender, EventArgs e)
        {
            if (Program.player.Inventory[InventoryListBox.SelectedIndex].weapon)
            {
                MessageBox.Show("You can not use a weapon.");
            }
            else if (Program.player.Inventory[InventoryListBox.SelectedIndex].potion)
            {
                if (Program.player.health == Program.player.maxHealth)
                {
                    MessageBox.Show("You already have maximum health!");
                }
                else
                {
                    Program.player.HealHealth(Program.player.Inventory[InventoryListBox.SelectedIndex].healingAmount);
                    Program.player.RemoveItem(Program.player.Inventory[InventoryListBox.SelectedIndex]);
                }
            }
            else
            {
                MessageBox.Show("You can not use this item.");
            }
            UpdateGame();
        }

        private void IncreaseStrengthButton_Click(object sender, EventArgs e)
        {
            if(Program.player.SkillPoints >= 2)
            {
                Program.player.SkillPoints-= 2;
                Program.player.strength++;
            }else
            {
                MessageBox.Show("You don't have enough Skill Points left!", "Error");

            }
            UpdateGame();
        }

        private void IncreaseVitalityButton_Click(object sender, EventArgs e)
        {
            if (Program.player.SkillPoints >= 1)
            {
                Program.player.SkillPoints--;
                Program.player.vitality++;
            }else
            {
                MessageBox.Show("You don't have enough Skill Points left!", "Error");

            }
            UpdateGame();

        }

        private void IncreaseWisdomButton_Click(object sender, EventArgs e)
        {
            if (Program.player.SkillPoints >= 1)
            {
                Program.player.SkillPoints--;
                Program.player.wisdom++;
            }
            else
            {
                MessageBox.Show("You don't have enough Skill Points left!", "Error");
            }
            UpdateGame();

        }

        private void FinishAllocationButton_Click(object sender, EventArgs e)
        {
            Program.player.levelingUp = false;
            Program.player.mana = Program.player.maxMana;
            Program.player.health = Program.player.maxHealth;
            UpdateGame();
        }

        private void GoUpButton_Click(object sender, EventArgs e)
        {
            Program.player.Move(Movement.Location.Direction.Up);
            UpdateGame();
        }

        private void GoDownButton_Click(object sender, EventArgs e)
        {
            Program.player.Move(Movement.Location.Direction.Down);
            UpdateGame();
        }
    }
}
