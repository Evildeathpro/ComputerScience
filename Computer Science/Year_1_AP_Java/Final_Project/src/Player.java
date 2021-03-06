import java.util.ArrayList;
import java.util.Arrays;

public class Player {

	public static double Health = 100, Exp = 0, Attack = 10, Speed = 10, HealthRemaining = 100, Defense = 10, Level = 0;
	public static ArrayList < String > Inventory = new ArrayList < String > ();
	public static int randomlyGeneratedRoomsEntered = 0;
	public static String weapon = "Hands", armor = "None", AttackName = "punched";
	public Player() {

	}
	public static void LevelUp() {
		if (Exp >= Math.pow(Level, 1.75) + 20 * (Level + 1)) {
			while (Exp >= Math.pow(Level, 1.75) + 20 * (Level + 1)) {
				Level += 1;
			}

			System.out.println("You leveled up to level " + NForm(Level) + "! As a result you fully restored your health!");
			CheckStats();
			HealthRemaining = Health;
			DisplayStats();
		}
	}
	public static void CheckStats() {
		if (weapon.equals("Hands")) {
			Attack = 4;
			AttackName = "punched";
		}
		if (weapon.equals("Knife")) {
			Attack = 15;
			AttackName = "tried to cut";
		}
		Attack += Level;
		Health = 100 + (5 * Level);
		if (Player.armor.equals("Magic Armor")) {
			Defense = 10 + (4.8 * Level) + 100;
		} else Defense = 10 + (2 * Level);
		Speed = 10 + (2 * Level);
		if (armor.equals("Magic Armor") && Enemy.Name.equals("Giant Death Knight")) {
			Attack *= 2;
			Defense *= 2;
			Speed *= 2;
		}

	}
	public static void DisplayStats() {
		CheckStats();
		System.out.print("Health: " + NForm(HealthRemaining) + "/" + NForm(Health) + "\tDefense: " + NForm(Defense) +
			"\nAttack: " + NForm(Attack) + "\tSpeed: " + NForm(Speed) + "\nExp: " + NForm(Exp) + "/" +
				NForm((Math.pow(Level, 1.75) + 20 * (Level + 1))));
	}
	public static boolean Fight() {
		CheckStats();
		System.out.print("The " + Enemy.Name + " has " + NForm(Enemy.HealthRemaining) + " health left. What will you do?\nYou can do the following: attack");
		while (Enemy.HealthRemaining > 0 && HealthRemaining > 0) {
			TextAdventure.userInputMethod(">");
			if (SpellingCheckOnAttack(TextAdventure.input.trim().toLowerCase())) {
				// (ArmorValue) / ( 200 + ( (HeroLvl) * 20) )
				if (Enemy.Speed < Speed) {
					int damage = (int)(Attack - (Attack * (Enemy.Defense / (200 + (Enemy.Level * 20)))));
					Enemy.HealthRemaining -= damage;
					if (Enemy.HealthRemaining > 0) {

						System.out.println("You " + AttackName + " the " + Enemy.Name + " and did " + NForm(damage) + " damage. The " + Enemy.Name + " now has " +
							NForm(Enemy.HealthRemaining) + " health left.");
						int enemyDamage = (int)(Enemy.Attack - (Enemy.Attack * (Defense / (200 + (Level * 20)))));
						Player.HealthRemaining -= enemyDamage;
						if (Player.HealthRemaining > 0) {
							System.out.print("The " + Enemy.Name + " " + Enemy.AttackName + " and did " + NForm(enemyDamage) + " damage. You now have " + NForm(HealthRemaining) + " health left.");
						} else {
							System.out.print("The " + Enemy.Name + " " + Enemy.AttackName + " and did " + NForm(enemyDamage) + " damage. You now have no health left.");
							return false;
						}
					} else {
						System.out.println("You " + AttackName + " the " + Enemy.Name + " and did " + NForm(damage) + " damage.");
						System.out.print("Congratulations! You have defeated the " + Enemy.Name + " and gained " + NForm(Enemy.Exp) + " Exp.");
						Exp += Enemy.Exp;
						return true;
					}
				} else {
					int enemyDamage = (int)(Enemy.Attack - (Enemy.Attack * (Defense / (200 + (Level * 20)))));
					Player.HealthRemaining -= enemyDamage;
					if (Player.HealthRemaining > 0) {
						System.out.println("The " + Enemy.Name + " " + Enemy.AttackName + " and did " + NForm(enemyDamage) + " damage. You now have " + NForm(HealthRemaining) + " health left.");
					} else {
						System.out.print("The " + Enemy.Name + " " + Enemy.AttackName + " and did " + NForm(enemyDamage) + " damage. You now have no health left.");
						return false;
					}
					int damage = (int)(Attack - (Attack * (Enemy.Defense / (200 + (Enemy.Level * 20)))));
					Enemy.HealthRemaining -= damage;
					if (Enemy.HealthRemaining > 0) {
						System.out.print("You " + AttackName + " the " + Enemy.Name + " and did " + NForm(damage) + " damage. The " + Enemy.Name + " now has " +
							NForm(Enemy.HealthRemaining) + " health left.");
					} else {
						System.out.println("You " + AttackName + " the " + Enemy.Name + " and did " + NForm(damage) + " damage.");
						System.out.print("Congratulations! You have defeated the " + Enemy.Name + " and gained " + NForm(Enemy.Exp) + " Exp.");
						Exp += Enemy.Exp;
						return true;
					}
				}


			} else {
				System.out.print("Please choose a valid option during the battle.");
			}
		}
		return false;
	}

	public static int NForm(double x) {
		return (int) Math.round(x);
	}
	
    private static boolean SpellingCheckOnAttack(String str)
    {
    	String[] words = { "attack", "atack", "sttack", "zttack", "qttack", "artack", "agtack", "aytack", "atrack", "atgack",
    			"atyack", "attsck", "attzck", "attqck", "attadk", "attavk", "attaxk", "attaci", "attaco", "attacl",
    			"attacm", "attacc" };
        return (Arrays.asList(words).contains(str));
    }
    
}