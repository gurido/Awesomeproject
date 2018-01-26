using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMentalDisorderDIctionary : MonoBehaviour {


	public static readonly Dictionary<int, string> MentalHealthDictionary = new Dictionary<int, string> {
		//according to DSM-5
		{1, "Attention-Deficit/Hyperactivity Disorder (ADHD)"},
		{2, "Autism Spectrum Disorder"},
		{3, "Conduct Disorder"},
		{4, "Disruptive Mood Dysregulation Disorder"},
		{5, "Eating Disorders"},
		{6, "Gender Dysphoria"},
		{7, "Intellectual Disability"},
		{8, "Internet Gaming Disorder"},
		{9, "Major Depressive Disorder and the Bereavement Exclusion"},
		{10, "Mild Neurocognitive Disorder"},
		{11, "Obsessive-Compulsive and Related Disorders"},
		{12, "Paraphilic Disorders"},
		{13, "Personality Disorder"},
		{14, "Posttraumatic Stress Disorder"},
		{15, "Schizophrenia"},
		{16, "Sleep-Wake Disorders"},
		{17, "Specific Learning Disorder"},
		{18, "Social COmmunication Disorder"},
		{19, "Somatic Symptom Disorder"},
		{20, "Substance-Related And Addictive Disorders"}
	};

	public static readonly Dictionary<int, string> PersonalityDisordersDictionary = new Dictionary<int, string> {
		{1, "Borderline Personality Disorder"},
		{2, "Obsessive-Compulsive Personality Disorder"},
		{3, "Avoidant Personality Disorder"},
		{4, "Schizotypal Personality Disorder"},
		{5, "Antisocial Personality Disorder"},
		{6, "Narcissistic Personality Disorder"}
	};
}
