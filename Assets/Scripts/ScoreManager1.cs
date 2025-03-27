using UnityEngine;
using TMPro; // Importer TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Score du joueur
    public TMP_Text scoreText; // Référence au texte UI TextMeshPro

    void Start()
    {
        UpdateScoreUI(); // Met à jour l'affichage du score dès le début
    }

    public void AddScore(int points)
    {
        score += points; // Incrémente le score
        Debug.Log("Score: " + score);
        UpdateScoreUI(); // Met à jour l'affichage du score
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score; // Affiche le score à l'écran
        }
    }
}
