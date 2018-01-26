using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRelationshipDictionary : MonoBehaviour {


	public static readonly Dictionary<int, string> PersonalRelationshipDictionary = new Dictionary<int, string> {

		{0, "Stranger"},
		{1, "Aware of existence"},
		{2, "Acquaintance"},
		{3, "Friend"},
		{4, "Good Friend"},
		{5, "Best Friend"},
		{6, "Bestie"},
		{7, ""},
		{8, ""},
		{9, ""},
		{10, "Internet Mutual"},
		{11, "Internet Friend"},
		{12, "Internet Idol"},
		{13, "Internet Crush"},
		{14, "Internet Rival"},
		{15, "Internet Enemy"},
		{16, "Internet Follower"},
		{17, "Internet Stalker"},
		{18, ""},
		{19, ""},
		{20, "Nuissance"},
		{21, "Disgusting"},
		{22, "Annoyance"},
		{23, "Rival"},
		{24, "Enemy"},
		{25, ""},
		{26, ""},
		{27, ""},
		{28, ""},
		{29, ""},
		{30, "Attracted"},
		{31, "Crush"},
		{32, ""},
		{33, ""},
		{34, ""},
		{35, ""},
		{36, ""},
		{37, ""},
		{38, ""},
		{39, ""},
		{40, ""},
		{41, ""},
		{42, ""},
		{43, ""},
		{44, ""},
		{45, ""},
		{46, ""},
		{47, ""},
		{48, ""},
		{49, ""},
		{50, ""},
		{51, ""},
		{52, ""},
		{53, ""},
		{54, ""},
		{55, ""},
		{56, ""},
		{53, ""},
		{54, ""},
		{55, ""},
		{56, ""}
	};


	public static readonly Dictionary<int, string> ProfessionalRelationshipDictionary = new Dictionary<int, string> {

		{0, "Not related"},
		{1, "Boss"},
		{2, "Subordinate"},
		{3, "Co-worker"},
		{4, "Client"},
		{5, "Competitor"}

	};

	public static readonly Dictionary<int, string> FamilyRelationshipDictionary = new Dictionary<int, string> {

		{0, "Not related"},
		{1, "Younger Brother"},
		{2, "Younger Sister"},
		{3, "Older Brother"},
		{4, "Older Sister"},
		{5, "Twin Brother"},
		{6, "Twin Sister"},
		{7, "Father"},
		{8, "Mother"},
		{9, "Son"},
		{10, "Daughter"},
		{11, "GrandFather"},
		{12, "GrandMother"},
		{13, "Grandson"},
		{14, "Granddaughter"},
		{15, "Great-Grandfather"},
		{16, "Great-Grandfather"},
		{17, "Great-Grandson"},
		{18, "Great-Granddaughter"},
		{19, "Great-Great-Grandfather"},
		{20, "Great-Great-Grandmother"},
		{21, "Great-Great-Grandson"},
		{22, "Great-Great-Granddaughter"},
		{23, "Great-Great-Great-Grandfather"},
		{24, "Great-Great-Great-Grandmother"},
		{25, "Great-Great-Great-Grandson"},
		{26, "Great-Great-Great-Greandaughter"},

		{27, "Cousin"},//male
		{28, "Cousin"},//female
		{29, "Uncle"},
		{30, "Aunt"},
		{31, "Nephew"},
		{32, "Niece"},
		{33, "Grand-Uncle"},
		{34, "Grand-Aunt"},
		{35, "Grand-Nephew"},
		{36, "Grand-Niece"},
		{37, "Great-Grand-Uncle"},
		{38, "Great-Grand-Aunt"},
		{39, "Great-Grand-Nephew"},
		{40, "Great-Grand-Niece"},
		{41, "Great-Great-Grand-Uncle"},
		{42, "Great-Great-Grand-Aunt"},
		{43, "Great-Great-Grand-Nephew"},
		{44, "Great-Great-Grand-Niece"},
		{45, "Great-Great-Great-Grand-Uncle"},
		{46, "Great-Great-Great-Grand-Aunt"},
		{47, "Great-Great-Great-Grand-Nephew"},
		{48, "Great-Great-Great-Grand-Niece"},

		{49, "Husband"},
		{50, "Wife"},
		{51, "Fiance"},
		{52, "Fiancee"},
		{53, "Ex-Husband"},
		{54, "Ex-Wife"},
		{55, "Partner"},
		{56, "Sibling"},
		{53, "Children"},
		{54, "Parent"},
		{55, "Grandparent"},
		{56, "Grandchild"}


	};
}
