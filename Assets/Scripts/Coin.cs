using UnityEngine;

public class Coin : MonoBehaviour {

    [Tooltip("¿Se trata de la moneda final de nivel?")]
    [SerializeField]
    private bool finalCoin;

    private void OnTriggerEnter2D(Collider2D other) {
        // Comprueba si la moneda ha sido conseguida por el jugador
        if (other.CompareTag("Player")) {
            if (!finalCoin) {
                // Moneda normal, se incrementa el contador
                ++GameManager.Coins;
                Destroy(transform.parent.gameObject);
            } else {
                // Moneda final, nivel completado
                GameManager.LevelFinished();
            }
        }
    }
}