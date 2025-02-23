using UnityEngine;
using UnityEngine.UI;

public class basicTesting : MonoBehaviour
{
    [Header("Gametrack Variables")]
        public float gameTimer = 0f;
        public float gameTimerSeconds = 0f;
        public float gameTimerMinutes = 0f;
        public int playerDeaths = 0;
        public int playerKills = 0;
        public bool didDodge = false;
        public bool didBlock = false;
        public bool hasLifesteal = false;
        public bool didLevel = false;
        public bool didDie = false;

    [Header("Player Variables")]
        public float attackValue = 1f;
        public float playerHealth = 100f;
        public float playerMaxHealth = 100f;
        public float playerDodge = 0f;
        public float playerDefense = 1f;
        public int playerGreed = 0;
        public int playerChallenge = 0;
        public float playerLifesteal = 0f;

    [Header("Experience Variables")]
        public int playerLevel = 1;
        public int playerExperience = 0;
        public int playerExperienceGain = 0;
        public int playerUnspentLevel = 0;
        public int playerExperienceThreshhold = 10;

    [Header("Enemy Variables")]
        public bool isEnemyAlive = false;
        public bool archlichFirstAppearance = true;
        public float enemyHealth = 0f;
        public float enemyMaxHealth = 0f;
        public float enemyDamage = 0f;
        public float enemyDamageBeforeDefense = 0f;
        public float enemyHitChance = 0f;
        public int enemyLevel = 0;
        public int enemyType = 0;

     [Header("UI Elements")]
        //Player Info
        public GameObject playerInformationVariables;
        Text playerInformationVariablesText;

        //Action Log
        public GameObject actionLog;
        Text actionLogText;

        //Undead Info
        public GameObject enemyInformationVariables;
        Text enemyInformationVariablesText;

        public GameObject enemyStatsVariables;
        Text enemyStatsVariablesText;

        //Undead Enemies
        public GameObject enemyAppearanceUndead_0;
        Text enemyAppearanceUndead_0Text;

        public GameObject enemyAppearanceUndead_1;
        Text enemyAppearanceUndead_1Text;

        public GameObject enemyAppearanceUndead_2;
        Text enemyAppearanceUndead_2Text;

        public GameObject enemyAppearanceUndead_3;
        Text enemyAppearanceUndead_3Text;

        public GameObject enemyAppearanceUndead_4;
        Text enemyAppearanceUndead_4Text;

        public GameObject enemyAppearanceUndead_5;
        Text enemyAppearanceUndead_5Text;

        public GameObject enemyAppearanceUndead_6;
        Text enemyAppearanceUndead_6Text;

        public GameObject enemyAppearanceUndead_7;
        Text enemyAppearanceUndead_7Text;

    //Buttons used to Level Up various Stats
    public void buttonInteractAttack()
    {
        if (playerUnspentLevel >= 1)
        {
            //If the player levels up, the players damage gains +3 and then multiplied by 25%
            attackValue = attackValue * 1.25f + 3;

            //Turns the damage float into an integer
            attackValue = (int)attackValue;
            playerUnspentLevel -= 1;
            Debug.Log("Attack Level Up!");
            Debug.Log("You now deal " +  attackValue + " damage!");
        }
    }

        public void buttonInteractDodge()
    {
        if (playerUnspentLevel >= 1 && playerDodge <= 65)
        {

            if (playerDodge >= 33)
            {
                playerDodge = playerDodge + 2;
            }

            else
            {
                playerDodge = playerDodge + 3;
            }

            playerUnspentLevel -= 1;
            Debug.Log("Dodge Level Up!");
            Debug.Log("You now have " +  playerDodge + "% chance to avoid damage!");
        }
    }

            public void buttonInteractDefense()
    {
        if (playerUnspentLevel >= 1)
        {
            //If the player levels up, the players defense gains +3 and then multiplied by 25%
            playerDefense = playerDefense * 1.25f + 3;

            //Turns the damage float into an integer
            playerDefense = (int)playerDefense;
            playerUnspentLevel -= 1;
            Debug.Log("Defense Level Up!");
            Debug.Log("You now block " +  playerDefense + " damage!");
        }
    }

    public void buttonInteractGreed()
    {
        if (playerUnspentLevel >= 1)
        {
            playerGreed = playerGreed + 1;

            playerUnspentLevel -= 1;
            Debug.Log("Greed Level Up!");
            Debug.Log("You now gain " +  playerExperienceGain + " XP!");
        }
    }

    public void buttonInteractChallenge()
    {
        if (playerUnspentLevel >= 1)
        {
            playerChallenge = playerChallenge + 1;
            playerUnspentLevel -= 1;
            Debug.Log("Challenge Level Up!");
            Debug.Log("You now face " +  playerChallenge + " level enemies!");
        }
    }

        public void buttonInteractLifesteal()
    {
        if (playerUnspentLevel >= 1)
        {
            playerLifesteal = playerLifesteal * 1.25f + 3;
            playerLifesteal = (int)playerLifesteal;
            playerUnspentLevel -= 1;
            Debug.Log("Lifesteal Level Up!");
            Debug.Log("You now heal " +  playerLifesteal + "when damage is dealt to enemies!");
        }
    }

    public void buttonInteractHealth()
    {
        if (playerUnspentLevel >= 1)
        {
            playerMaxHealth = playerMaxHealth * 1.25f + 3;
            playerUnspentLevel -= 1;
            playerMaxHealth = (int)playerMaxHealth;
            Debug.Log("Maxhealth Up!");
            Debug.Log("You now have " +  playerMaxHealth + "!");
        }
    }

    void Start()
    {
        Debug.Log("Game has Launched!");
        Debug.Log("Gathering UI Elements");

        //UI Elements
        playerInformationVariablesText = playerInformationVariables.GetComponent<Text>();
        actionLogText = actionLog.GetComponent<Text>();
        enemyInformationVariablesText = enemyInformationVariables.GetComponent<Text>();
        enemyStatsVariablesText = enemyStatsVariables.GetComponent<Text>();

        //Undead Enemies
        enemyAppearanceUndead_0Text = enemyAppearanceUndead_0.GetComponent<Text>();
        enemyAppearanceUndead_1Text = enemyAppearanceUndead_1.GetComponent<Text>();
        enemyAppearanceUndead_2Text = enemyAppearanceUndead_2.GetComponent<Text>();
        enemyAppearanceUndead_3Text = enemyAppearanceUndead_3.GetComponent<Text>();
        enemyAppearanceUndead_4Text = enemyAppearanceUndead_4.GetComponent<Text>();
        enemyAppearanceUndead_5Text = enemyAppearanceUndead_5.GetComponent<Text>();
        enemyAppearanceUndead_6Text = enemyAppearanceUndead_6.GetComponent<Text>();
        enemyAppearanceUndead_7Text = enemyAppearanceUndead_7.GetComponent<Text>();

        //Hide at Game Start
        enemyAppearanceUndead_0Text.color = Color.black;
        enemyAppearanceUndead_1Text.color = Color.black;
        enemyAppearanceUndead_2Text.color = Color.black;
        enemyAppearanceUndead_3Text.color = Color.black;
        enemyAppearanceUndead_4Text.color = Color.black;
        enemyAppearanceUndead_5Text.color = Color.black;
        enemyAppearanceUndead_6Text.color = Color.black;
        enemyAppearanceUndead_7Text.color = Color.black;

        //Intro Text
        actionLogText.text = " > You awake in a cold dark labyrinth, a rusted weapon clutched in your rotting hands. \nUndead listlessly shuffle the dark hallways. Utterly quiet aside from the clatter of bones. \nBy some miracle, unlike the rest of these undead, you retain your humanity. \nIt seems it is up to you to slay the monsters of this catacomb... \nThe Archlich *must* be stopped.";
    }

    void Update()
    {
        //Timer
        gameTimer += Time.deltaTime;
        
        if (gameTimer >= 1f)
        {
            gameTimerSeconds = gameTimerSeconds + 1f;
            gameTimer = gameTimer = 0f;
        }

        if (gameTimerSeconds >= 60f)
        {
            gameTimerMinutes = gameTimerMinutes + 1f;
            gameTimerSeconds = 0f;
        }

            //UI
        //Enemy Names + LvL
        playerInformationVariablesText.text = "Timer: " + gameTimerMinutes + " : " + gameTimerSeconds + "\nDeaths: " + playerDeaths + "\nKills: " + playerKills + "\n\nXP: " + playerExperience.ToString() + "\nXP per Kill: " + (playerGreed * 2 + playerChallenge + 1) +"x" + "\nXP for next LvL: " + playerExperienceThreshhold + "\n\nLvl: " + playerLevel + " (" + playerUnspentLevel + ")" + "\nAttack: " + attackValue + "\nDodge: " + playerDodge + "\nDefense: " + playerDefense + "\nGreed: " + playerGreed + "\nChallenge: " + playerChallenge + "\nLifesteal: " + playerLifesteal + "\n\nMax HP: " + playerMaxHealth + "\nCurrent HP: " + playerHealth;
            if (enemyType == 1)
            {
            enemyInformationVariablesText.text = "Lvl " + enemyLevel + " Possessed Ruin";
            }

                if (enemyType == 2)
                {
                enemyInformationVariablesText.text = "Lvl " + enemyLevel + " Rabble";
                }

                    if (enemyType == 3)
                    {
                    enemyInformationVariablesText.text = "Lvl " + enemyLevel + " Footsoldier";
                    }

                        if (enemyType == 4)
                        {
                        enemyInformationVariablesText.text = "Lvl " + enemyLevel + " Champion";
                        }

                            if (enemyType == 5)
                            {
                            enemyInformationVariablesText.text = "Lvl " + enemyLevel + " Necromancer";
                            }

                                if (enemyType == 6)
                                {
                                enemyInformationVariablesText.text = "Lvl " + enemyLevel + " Lich";
                                }

                                    if (enemyType == 7)
                                    {
                                    enemyInformationVariablesText.text = "Lvl " + enemyLevel + " Archlich Standard Bearer";
                                    }

                                        if (enemyType == 8)
                                        {
                                        enemyInformationVariablesText.text = "Lvl " + enemyLevel + " The Archlich";
                                        }
        
        //Enemy Stats
        enemyStatsVariablesText.text = "HP: " + enemyMaxHealth + " / " + enemyHealth + "\n" + "DMG: " + enemyDamage;


            //Attacking and killing enemies + subsequent level up
        //When space is pressed, the player attacks and the enemy counter attacks
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You have swung your weapon!");

             if (isEnemyAlive == true)
                {
                    //Enemy takes damage equal to weapon damage then gain health equal to lifesteal
                    enemyHealth -= attackValue;
                    playerHealth = playerHealth + playerLifesteal;

                    if (playerLifesteal > 0)
                    {
                        Debug.Log("Player has gained " + playerLifesteal + " and is now on " + playerHealth);
                        hasLifesteal = true;
                    }

                    if (playerHealth >= playerMaxHealth)
                    {
                        playerHealth = playerMaxHealth;
                    }

                    Debug.Log("Enemy has taken " + attackValue + " damage!");
                    Debug.Log("Enemy is now on " + enemyHealth + " health!");

                    //Player Takes Damage (Dodge/Defense)
                    enemyHitChance = Random.Range(1, 101);

                    //Defense
                    enemyDamage = enemyDamage - playerDefense;
                    if (enemyDamage <= 0)
                    {
                        Debug.Log("Blocked!");
                        enemyDamage = 0;
                        didBlock = true;
                    }

                    //Dodge
                    if(enemyHitChance <= playerDodge)
                    {
                        Debug.Log("Dodged!");
                        enemyDamage = 0;
                        //If a player both blocks and dodges, it only counts the dodge
                        didDodge = true;
                        didBlock = false;
                    }

                    //Player Takes Damage
                    playerHealth -= enemyDamage;
                    Debug.Log("Enemy has attacked and dealt " + enemyDamage + " damage!");
                    Debug.Log("You now have" + playerHealth + " health!");

                    if (enemyHealth <= 1f)
                    {
                        //When the enemy is below 1 Health: gain experience points and make it dead.
                        playerExperienceGain = 1 + (playerGreed * 2) + (playerChallenge);
                        playerExperience += playerExperienceGain * enemyLevel;
                        playerKills = playerKills + 1;

                        Debug.Log("Enemy has died!");
                        Debug.Log("You have gained " + playerExperienceGain + " experience points!");
                        Debug.Log("You now have " + playerExperience + " experience points!");
                        Debug.Log("You gained this because, Greed is " + playerGreed + " and Enemy level is " + enemyLevel);

                        //Kill the enemy
                        isEnemyAlive = false;
                        enemyMaxHealth = 0;
                    }

                    //Player Death
                    if (playerHealth <= 1f)
                    {
                        Debug.Log("You have died!");
                        playerHealth = playerMaxHealth;
                        playerDeaths += 1;
                        didDie = true;

                    }

                }
                    //This isn't called, just a failsafe when implmenting new mechanics
                    else
                    {
                        Debug.Log("You miss!");
                    }

                    //Leveling up
                    if (playerExperience >= playerExperienceThreshhold)
                    {
                        Debug.Log("You may now Level Up!");
                        Debug.Log("Press Space to level up!");
                        didLevel = true;

                        if (Input.GetKeyDown(KeyCode.Space))
                        {
                            //If the amount of player experience is equal or higher than the threshold, they gain +1 level and double the next threshold
                            playerLevel += 1;
                            playerUnspentLevel += 5;
                            playerExperienceThreshhold *= 2;
                            Debug.Log("Level up!");
                            Debug.Log("You are now level " + playerLevel);
                            Debug.Log("Next level at " + playerExperienceThreshhold);

                            //Win condition Minor
                            if (playerLevel == 5)
                            {
                                Debug.Log("You have won!");
                            }
                        }
                    }
                    
                    //The Condition Check Tangle, Abandon hope all ye who enter here! (There is certainly a better way to do this, loe, I am but a pleb)

                    //Did the player Block + Lifesteal + Dodge + Level?
                    if (didBlock == true && hasLifesteal == true && didDodge == true && didDie == false && didLevel == true)
                    {
                    actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > You restore " + playerLifesteal + " health" + "\n > The enemy counterattacks, but you dodged!" + "\n > Level up!" + "\n > You died... But soon rise back onto your feet.";
                    }
                        //Did the player Block + Lifesteal + Dodge?
                        if (didBlock == true && hasLifesteal == true && didDodge == true && didDie == false && didLevel == false)
                        {
                        actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > You restore " + playerLifesteal + " health" + "\n > The enemy counterattacks, but you dodged!" + "\n > You died... But soon rise back onto your feet.";
                        }
                            //Did the player Block + Lifesteal + Dodge?
                            if (didBlock == true && hasLifesteal == true && didDodge == true && didDie == false && didLevel == false)
                            {
                            actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > You restore " + playerLifesteal + " health" + "\n > The enemy counterattacks, but you blocked!";
                            }
                                
                                //Did the player Block + Lifesteal?
                                if (didBlock == true && hasLifesteal == true && didDodge == false && didDie == false && didLevel == false)
                                {
                                actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > You restore " + playerLifesteal + "\n > The enemy counterattacks, but you blocked!";
                                }
                                    //Did the player Block?
                                    if (didBlock == true && hasLifesteal == false && didDodge == false && didDie == false && didLevel == false)
                                    {
                                    actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > The enemy counterattacks, but you blocked!";
                                    }
                                        //Did the player not trigger conditions?
                                        if (didBlock == false && hasLifesteal == false && didDodge == false && didDie == false && didLevel == false)
                                        {
                                        actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > The enemy counterattacks, dealing " + enemyDamage + " damage";
                                        }
                                            //Did the player Level?
                                            if (didBlock == false && hasLifesteal == false && didDodge == false && didDie == false && didLevel == true)
                                            {
                                            actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > The enemy counterattacks, dealing " + enemyDamage + " damage" + "\n > Level up!";
                                            }

                                                //Did the player Level + Die?
                                                if (didBlock == false && hasLifesteal == false && didDodge == false && didDie == true && didLevel == true)
                                                {
                                                actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > The enemy counterattacks, dealing " + enemyDamage + " damage" + "\n > Level up!";
                                                }

                                                    //Did the player Die + Lifesteal?
                                                    if (didBlock == false && hasLifesteal == true && didDodge == false && didDie == true && didLevel == false)
                                                    {
                                                    actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > You restore " + playerLifesteal + " health" + "\n > The enemy counterattacks, dealing " + enemyDamage + " damage" + "\n > You died... But soon rise back onto your feet.";
                                                    }

                                                        //Did the player Level + Dodge?
                                                        if (didBlock == false && hasLifesteal == false && didDodge == true && didDie == false && didLevel == true)
                                                        {
                                                        actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > The enemy counterattacks, but you dodged!" + "\n > Level up!";
                                                        }

                                                            //Did the player Level + Block?
                                                            if (didBlock == true && hasLifesteal == false && didDodge == false && didDie == false && didLevel == true)
                                                            {
                                                            actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > The enemy counterattacks, but you blocked!" + "\n > Level up!";
                                                            }

                                                                //Did the player Level + Lifesteal?
                                                                if (didBlock == false && hasLifesteal == true && didDodge == false && didDie == false && didLevel == true)
                                                                {
                                                                actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > You restore " + playerLifesteal + " health" + "\n > The enemy counterattacks, dealing " + enemyDamage + " damage" + "\n > Level up!";
                                                                }

                                                                    //Did the player Lifesteal?
                                                                    if (didBlock == false && hasLifesteal == true && didDodge == false && didDie == false && didLevel == false)
                                                                    {
                                                                    actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > You restore " + playerLifesteal + " health" + "\n > The enemy counterattacks, dealing " + enemyDamage + " damage";
                                                                    }
                                                                        
                                                                        //Did the player Dodge?
                                                                        if (didBlock == false && hasLifesteal == false && didDodge == true && didDie == false && didLevel == false)
                                                                        {
                                                                        actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > The enemy counterattacks, but you dodged!";
                                                                        }

                                                                            //Did the player Dodge + Lifesteal?
                                                                            if (didBlock == false && hasLifesteal == true && didDodge == true && didDie == false && didLevel == false)
                                                                            {
                                                                            actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > You restore " + playerLifesteal + " health" + "\n > The enemy counterattacks, but you dodged!";
                                                                            }

                                                                                //Did the player Block + Lifesteal?
                                                                                if (didBlock == true && hasLifesteal == true && didDodge == false && didDie == false && didLevel == false)
                                                                                {
                                                                                actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > You restore " + playerLifesteal + " health" + "\n > The enemy counterattacks, but you blocked!";
                                                                                }

                                                                                    //Did the player Die + Level + Lifesteal?
                                                                                    if (didBlock == false && hasLifesteal == true && didDodge == false && didDie == true && didLevel == true)
                                                                                    {
                                                                                    actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > You restore " + playerLifesteal + " health" + "\n > The enemy counterattacks, dealing " + enemyDamage + " damage" + "\n > Level up!" + "\n > You died... But soon rise back onto your feet.";
                                                                                    }

                                                                                         //Did the player Die?
                                                                                        if (didBlock == false && hasLifesteal == false && didDodge == false && didDie == true && didLevel == false)
                                                                                        {
                                                                                        actionLogText.text = " > You swing your weapon, dealing " + attackValue + " damage" + "\n > The enemy counterattacks, dealing " + enemyDamage + " damage" + "\n > You died... But soon rise back onto your feet.";
                                                                                        }
                                                                                            //Did the player kill the Final Boss?
                                                                                            if (enemyType == 8 && isEnemyAlive == false)
                                                                                            {
                                                                                            actionLogText.text = " > The Archlich has been defeated! \n But.. What's this? \n His corpse twitches and rises. \n It seems your eternity will be spent in conflict with the Archlich \n You win?";
                                                                                            }

                    //Reset Condition Checks and Block
                    enemyDamage = enemyDamageBeforeDefense;
                    didBlock = false;
                    didDie = false;
                    didLevel = false;
                    hasLifesteal = false;
                    didDodge = false;
                    Debug.Log("Values reset: " + " " + didBlock + " " + didDie + " " + didLevel + " " + hasLifesteal + " " + didDodge);
        }


        //Spawning Enemies
        if (isEnemyAlive == false)
        {
            //If the enemy is dead, spawn a new one with random health based on its level (also random)
            isEnemyAlive = true;
            enemyLevel = Random.Range(1, 5) * (playerChallenge + 1);
            
            //Spawn an enemy based on playerChallenge level
            if (playerChallenge <= 3)
            {
                enemyType = Random.Range(1,2);
            }

            if (playerChallenge >= 4 && playerChallenge <= 6)
            {
                enemyType = Random.Range(1,3);
            }

            if (playerChallenge >= 7 && playerChallenge <= 9)
            {
                enemyType = Random.Range(1,4);
            }

            if (playerChallenge >= 10 && playerChallenge <= 12)
            {
                enemyType = Random.Range(2,5);
            }

            if (playerChallenge >= 13 && playerChallenge <= 15)
            {
                enemyType = Random.Range(2,6);
            }

            if (playerChallenge >= 16 && playerChallenge <= 18)
            {
                enemyType = Random.Range(3,6);
            }

            if (playerChallenge >= 19 && playerChallenge <= 21)
            {
                enemyType = Random.Range(4,6);
            }

            if (playerChallenge >= 22 && playerChallenge <= 24)
            {
                enemyType = Random.Range(4,7);
            }

            if (playerChallenge >= 25 && playerChallenge <= 27)
            {
                enemyType = Random.Range(6,8);
            }

            if (playerChallenge >= 28 && playerChallenge <= 30)
            {
                enemyType = Random.Range(7,8);
            }

            if (playerChallenge >= 31)
            {
                enemyType = Random.Range(8,9);
            }

        //Remove all Previous Enemies
        enemyAppearanceUndead_0Text.color = Color.black;
        enemyAppearanceUndead_1Text.color = Color.black;
        enemyAppearanceUndead_2Text.color = Color.black;
        enemyAppearanceUndead_3Text.color = Color.black;
        enemyAppearanceUndead_4Text.color = Color.black;
        enemyAppearanceUndead_5Text.color = Color.black;
        enemyAppearanceUndead_6Text.color = Color.black;
        enemyAppearanceUndead_7Text.color = Color.black;

            //What enemy appears?
            if (enemyType == 1)
            {
            enemyAppearanceUndead_0Text.color = Color.white;
            }
                if (enemyType == 2)
                {
                enemyAppearanceUndead_1Text.color = Color.white;
                }
                    if (enemyType == 3)
                    {
                    enemyLevel *= 2;
                    enemyAppearanceUndead_2Text.color = Color.white;
                    }
                        if (enemyType == 4)
                        {
                        enemyLevel *= 3;
                        enemyAppearanceUndead_3Text.color = Color.white;
                        }
                            if (enemyType == 5)
                            {
                            enemyAppearanceUndead_4Text.color = Color.white;
                            enemyLevel *= 4;
                            }
                                if (enemyType == 6)
                                {
                                enemyAppearanceUndead_5Text.color = Color.white;
                                enemyLevel *= 5;
                                }
                                    if (enemyType == 7)
                                    {
                                    enemyAppearanceUndead_6Text.color = Color.white;
                                    enemyLevel *= 6;
                                    }
                                        if (enemyType == 8)
                                        {
                                        enemyAppearanceUndead_7Text.color = Color.white;
                                        }

            //Random number between 1 and 10 for health, then multipled by enemyLevel
            Debug.Log("A level " + enemyLevel + " enemy has appeared!");
            Debug.Log("Enemy type " + enemyType + " has appeared!");
            enemyHealth = Random.Range(1, 11) * enemyLevel;
            enemyMaxHealth = enemyMaxHealth + enemyHealth;
            enemyDamage = Random.Range(1, 11) * enemyLevel;

            //This enemy has more standard stats
            if (enemyType == 1)
            {
                enemyDamage = Random.Range(1,4) + playerChallenge;
                enemyLevel = 1 + playerChallenge;
                enemyHealth = 10 + playerChallenge;
                enemyMaxHealth = 10 + playerChallenge;
            }
                
                //Final Boss Stats (First Appearance)
                if (enemyType == 8 && archlichFirstAppearance == true)
                {
                    enemyLevel = 50 * playerChallenge;
                    enemyDamage = 10 * enemyLevel;
                    enemyHealth = 25 * enemyLevel;
                    enemyMaxHealth = 25 * enemyLevel;
                    actionLogText.text = " > The Archlich has revealed himself! The wizard turned madman, turned warlord, that made home in this necropolis. Years spent raising an undead army...\n He must be stopped.";
                    archlichFirstAppearance = false;
                }
                    
                    //Final Boss Stats (Repeated Appearance)
                    if (enemyType == 8 && archlichFirstAppearance == false)
                    {
                        enemyLevel = 50 * playerChallenge;
                        enemyDamage = 10 * enemyLevel;
                        enemyHealth = 25 * enemyLevel;
                        enemyMaxHealth = 25 * enemyLevel;
                    }

            //Sets base enemy damage
            enemyDamageBeforeDefense = enemyDamage;
        }
    }
}
