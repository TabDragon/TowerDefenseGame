using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class RoundsSurvided : MonoBehaviour
{
    public Text roundsText;

    private void OnEnable()
    {
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        roundsText.text = "0";
        int round = 0;

        yield return new WaitForSeconds(0.7f);

        while (round < PlayerStats.Rounds)
        {
            round++;
            roundsText.text = round.ToString();

            yield return new WaitForSeconds(0.05f);
        }
    }
}
