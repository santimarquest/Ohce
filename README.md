Kata Ohce

La idea es la siguiente:
El programa ohce necesita dos colaboradores para poder funcionar, un objeto StringTool que sabe hacer reverse y mirar si una palabra es o no palíndrome, y un objeto Greetings que sabe saludar según la hora.
Se podrían hacer testn del programa ohce, sin tener nada implementado de sus colaboradores, mockeando su comportamiento.
Es decir, primero implementaríamos el comportamiento del programa,  y después su colaboradores.
En realidad, da igual el orden en que hagamos la implementación, mientras respetemos la idea principal: se testea el programa a partir de mocks de sus colaboradores, independientemente de si estos colaboradores están ya implementados completamente,  o a medias.

02-06-2024
En el estado actual se ve como se puede testear el comportamiento de la clase ohce.cs, mockeando sus colaboradores. Uno de ellos está implementado (stringTool), pero el otro todavía no (greetings).
Doy por finalizado el objetivo de esta kata, quizás más adelante la pueda completar.
