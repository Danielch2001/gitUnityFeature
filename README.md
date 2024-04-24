gitUnityFeature
Recoger Objetos + Mostrar texto pantalla

un juego en Unity en el que un jugador puede recoger objetos (en este caso, comida) y se muestra la puntuación en pantalla.

Script del Jugador (Jugador.cs): Explicación:

Se define una velocidad (speed) para el jugador. Se obtiene una referencia al componente Rigidbody del jugador en el método Start. En el método Update, se obtienen las entradas del teclado para el movimiento horizontal y vertical. Se crea un vector movement para actualizar la velocidad del Rigidbody del jugador. La posición del jugador se actualiza en consecuencia.

Script del GameManager (GameManager.cs):

Explicación:

Se utiliza TMP_Text de TextMeshPro para mostrar la puntuación en pantalla. La puntuación (comidaNumero) se inicializa en cero en el método Start. La función ActualizarTextoPuntuacion se encarga de actualizar el texto de la puntuación. AddComida incrementa la puntuación cuando se llama y actualiza el texto.

Script de la Comida (Comida.cs):

Explicación:

Utiliza OnCollisionEnter para detectar colisiones con otros objetos. Verifica si el objeto con el que colisiona tiene la etiqueta "Player". Accede al GameManager mediante FindObjectOfType y llama a la función AddComida para incrementar la puntuación. Finalmente, destruye el objeto de comida.

Este conjunto de scripts proporciona una estructura básica para un juego en Unity donde el jugador puede recoger objetos (comida) y se muestra la puntuación en pantalla. Puedes expandir y personalizar este código según tus necesidades y requisitos específicos del juego.

El proyecto se encuentra en la rama master.
