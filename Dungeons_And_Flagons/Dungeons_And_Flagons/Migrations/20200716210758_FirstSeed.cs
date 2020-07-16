using Microsoft.EntityFrameworkCore.Migrations;

namespace Dungeons_And_Flagons.Migrations
{
    public partial class FirstSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "ID", "Category", "Name", "Path", "Permission", "Summary" },
                values: new object[,]
                {
                    { 1, "Content", "Basic Rules", "./Books/BasicRules.pdf", 3, "Basic Set of rules to start on your adventure" },
                    { 2, "Content", "Player's Handbook", "./Books/PHB.pdf", 3, "The Player’s Handbook is the essential reference for every Dungeons & Dragons roleplayer. It contains rules for character creation and advancement, backgrounds and skills,exploration and combat, equipment, spells, and much more. Use this book to create exciting characters from among the most iconic D&D races and classes. " },
                    { 3, "Adventure", "Sword Coast Adventurer’s guide", "./Books/Scag", 3, "A of Faerûn that comprises shining paragons of civilization and culture, perilous locales fraught with dread and evil, and encompassing them all, a wilderness that offers every explorer vast opportunity and simultaneously promises great danger. " }
                });

            migrationBuilder.InsertData(
                table: "Subraces",
                columns: new[] { "ID", "BookID", "Description", "Features", "MainRace", "Name", "Source" },
                values: new object[,]
                {
                    { 1, null, "In the reckonings of most worlds,humans are the youngest of the common races,late to arrive on the world scene and short - lived in comparison to dwarves,elves,an d dragons.Perhaps it is because of their shorter lives that they strive to achieve as much as they can in the years they are given.Or maybe they feel they have something to prove to the elder races,and that’s why they build their mighty empires on the foundation of conquest and trade.Whatever drives them,humans are the innovators,the achievers,and the pioneers of the worlds.", "Increases all ability Scores by 1,your base walking speed is 30 feet,you can speak,read and write common and one language of your choice", "Human", "Regular", 1 },
                    { 2, null, "As a wood elf, you have keen senses and intuition, and your fleet feet carry you quickly and stealthily through your native forests.This category includes the wild elves(grugach) of Greyhawk and the Kagonesti of Dragonlance, as well as the races called wood elves in Greyhawk and the Forgotten Realms.In Faerûn, wood elves(also called wild elves, green elves, or forest elves) are reclusive and distrusting of non - elves.", " Your Dexterity increases by 2 and your wisdom increases by 1, your base walking speed is 35 feet, You have darkvision, proficiency with Perception Skill, Advantage against being Charmed, and magic can’t put you to sleep, Trance, you dont sleep you meditate for 4 hours and gain the beneficts of a long rest, You can speak, read, write common and elvish.", "Elf", "Wood Elf", 2 },
                    { 3, null, "As a Lightfoot Halfling, you can easily hide from notice, even using other people as cover.You’re inclined to be affable and get along well with others. Lightfoots are more prone to wanderlust than other Halflings, and often dwell alongside other races or take up a nomadic life.", "Your Dexterity increases by 2, your Charisma increases by 1, As a Halfling your size is Small, your base walking speed is 25 feet, you are Lucky, whenever you roll a 1 on the d20 for na attack roll, ability check or Saving throw you can reroll the die, Brave, you have advantage against being Frightened. Nimbleness, you can move through the space of a creature one size bigger than you.", "Halfling", "Lightfoot", 2 },
                    { 4, null, "Physically similar to other dwarves in some ways, duergar are wiry and lean, with black eyes and bald heads, with the males growing long, unkempt, gray beards. Duergar value toil above all else. Showing emotions other than grim determination or wrath is frowned on in their culture, but they can sometimes seem joyful when at work. They have the typical dwarven appreciation for order, tradition, and impeccable craftsmanship, but their goods are purely utilitarian, disdaining aesthetic or artistic value.", "Your Consitution Increases by 2 , and your strenght by 1, your base walking speed is 25 feet. Superior Darkvision, your darkvision has a radius of 120 feet.You have advantage on on Saving Throws agains’t poison and you have Resistance against poison Damage. Sunlight Sensitivity, you have disadvantage on attack rolls and perception checks that rely on sight when you are under direct sunlight. You can read,write,and speak common,swarvish and undercommon", "Dwarf", "Duergar", 3 }
                });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "ID", "CastingTime", "Components", "Description", "Duration", "Level", "Name", "Range", "School", "Source" },
                values: new object[,]
                {
                    { 1, "1 Action", "V", "Choose one creature that you can see within range.The target begins a comic dance in place: shuffling, tapping its feet, and capering for the duration.Creatures that can't be charmed are immune to this spell.A dancing creature must use all its movement to dance without leaving its space and has disadvantage on Dexterity saving throws and attack rolls. While the target is affected by this spell, other creatures have advantage on attack rolls against it.As an action, a dancing creature makes a Wisdom saving throw to regain control of itself.On a successful save, the spell ends.", "Concentration 1 Minute", 6, "Otto's Irresistible Dance", "30 ft", "Enchantment", 1 },
                    { 2, "1 Action", "V,S,M - (a lodestone and a pinch of dust)", "A thin green ray springs from your pointing finger to a target that you can see within range.The target can be a creature, an object, or a creation of magical force, such as the wall created by wall of force.A creature targeted by this spell must make a Dexterity saving throw. On a failed save, the target takes 10d6 + 40 force damage. The target is disintegrated if this damage leaves it with 0 hit points.A disintegrated creature and everything it is wearing and carrying, except magic items, are reduced to a pile of fine gray dust.The creature can be restored to life only by means of a true resurrection or a wish spell.This spell automatically disintegrates a Large or smaller nonmagical object or a creation of magical force.If the target is a Huge or larger object or creation of force, this spell disintegrates a 10-foot- cube portion of it. A magic item is unaffected by this spell.At Higher Levels.When you cast this spell using a spell slot of 7th level or higher, the damage increases by 3d6 for each slot level above 6th.", "Instantaneou", 6, "Disintegrate", "60 ft", "Transmutation", 1 },
                    { 3, "1 Action", "V", "Each object in a 20-foot cube within range is outlined in blue, green, or violet light(your choice). Any creature in the area when the spell is cast is also outlined in light if it fails a Dexterity saving throw. For the duration, objects and affected creatures shed dim light in a 10-foot radius.Any attack roll against an affected creature or object has advantage if the attacker can see it, and the affected creature or object can't benefit from being invisible.", "Concentration 1 Minute", 1, "Fearie Fire", "60 ft /20 ft Square", "Evocation", 1 },
                    { 4, "1 Action", "V,S,M - (a tiny ball of bat guano and sulfur)", "A bright streak flashes from your pointing finger to a point you choose within range and then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot-radius sphere centered on that point must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed save, or half as much damage on a successful one.The fire spreads around corners. It ignites flammable objects in the area that aren't being worn or carried.”", "Instantaneous", 3, "Fire Ball", "150 ft /20 ft Square", "Evocation", 1 },
                    { 5, "1 Action", "V,S,M - (a pinch of powdered iron)", "You cause a creature or an object you can see within range to grow larger or smaller for the duration. Choose either a creature or an object that is neither worn nor carried. If the target is unwilling, it can make a Constitution saving throw. On a success, the spell has no effect.If the target is a creature, everything it is wearing and carrying changes size with it. Any item dropped by an affected creature returns to normal size at once.Enlarge. The target's size doubles in all dimensions, and its weight is multiplied by eight. This growth increases its size by one category-- from Medium to Large, for example. If there isn't enough room for the target to double its size, the creature or object attains the maximum possible size in the space available. Until the spell ends, the target also has advantage on Strength checks and Strength saving throws. The target's weapons also grow to match its new size. While these weapons are enlarged, the target's attacks with them deal 1d4 extra damage.Reduce. The target's size is halved in all dimensions, and its weight is reduced to one-eighth of normal. This reduction decreases its size by one category--from Medium to Small, for example. Until the spell ends, the target also has disadvantage on Strength checks and Strength saving throws. The target's weapons also shrink to match its new size. While these weapons are reduced, the target's attacks with them deal 1d4 less damage (this can't reduce the damage below 1).", "Concentration 1 Minute", 2, "Enlarge/Reduce", "30 ft", "Transmutation", 1 },
                    { 6, "1 Action", "V", "Wish is the mightiest spell a mortal creature can cast. By simply speaking aloud, you can alter the very foundations of reality in accord with your desires.  the basic use of this spell is to duplicate any other spell of 8th level or lower. You don't need to meet any requirements in that spell, including costly components. The spell simply takes effect.Alternatively, you can create one of the following effects of your choice:You create one object of up to 25,000 gp in value that isn't a magic item. The object can be no more than 300 feet in any dimension, and it appears in an unoccupied space you can see on the ground.You allow up to twenty creatures that you can see to regain all hit points, and you end all effects on them described in the greater restoration spell.You grant up to ten creatures that you can see resistance to a damage type you choose.You grant up to ten creatures you can see immunity to a single spell or other magical effect for 8 hours. For instance, you could make yourself and all your companions immune to a lich's life drain attack.You undo a single recent event by forcing a reroll of any roll made within the last round (including your last turn). Reality reshapes itself to accommodate the new result. For example, a wish spell could undo an opponent's successful save, a foe's critical hit, or a friend's failed save. You can force the reroll to be made with advantage or disadvantage, and you can choose whether to use the reroll or the original roll.You might be able to achieve something beyond the scope of the above examples. State your wish to the GM as precisely as possible. The GM has great latitude in ruling what occurs in such an instance; the greater the wish, the greater the likelihood that something goes wrong. This spell might simply fail, the effect you desire might only be partly achieved, or you might suffer some unforeseen consequence as a result of how you worded the wish. For example, wishing that a villain were dead might propel you forward in time to a period when that villain is no longer alive, effectively removing you from the game. Similarly, wishing for a legendary magic item or artifact might instantly transport you to the presence of the item's current owner.The stress of casting this spell to produce any effect other than duplicating another spell weakens you. After enduring that stress, each time you cast a spell until you finish a long rest, you take 1d10 necrotic damage per level of that spell. This damage can't be reduced or prevented in any way. In addition, your Strength drops to 3, if it isn't 3 or lower already, for 2d4 days. For each of those days that you spend resting and doing nothing more than light activity, your remaining recovery time decreases by 2 days. Finally, there is a 33 percent chance that you are unable to cast wish ever again if you suffer this stress.", "Instantaneous", 9, "Wish", "Self", "Conjuration", 1 },
                    { 7, "1 Action", "V,S,M - (an eyelash encased in gum arabic)", "A creature you touch becomes invisible until the spell ends. Anything the target is wearing or carrying is invisible as long as it is on the target's person. The spell ends for a target that attacks or casts a spell.At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, you can target one additional creature for each slot level above 2nd.", "Concentration 1 Hour", 2, "Invisibility", "Touch", "Illusion", 1 }
                });

            migrationBuilder.InsertData(
                table: "SubracesSpell",
                columns: new[] { "SubraceID", "SpellID" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "SubracesSpell",
                columns: new[] { "SubraceID", "SpellID" },
                values: new object[] { 4, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subraces",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subraces",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subraces",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubracesSpell",
                keyColumns: new[] { "SubraceID", "SpellID" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "SubracesSpell",
                keyColumns: new[] { "SubraceID", "SpellID" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subraces",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
