# Objetivos de Aleja

Tenemos que desarrollar Aleja, un asistente personal basado en vos similar a Amazon
Echo o Google Home: una pequeña computadora sin pantalla que interactúa con el
usuario a través de preguntas por voz. La primera versión debe soportar consultas
estructuradas​ con los siguientes formatos:
● Aleja, ¿cuánto es ​4 + 5?
● Aleja, ¿cómo se dice ​hola en ​griego?
● Aleja, ¿cuánto me toma llegar a ​Córdoba y Medrano?

## Arquitectura:
[Capturador de sonido -> Decodificador ->Tokenificador ->Procesador.]

## Problema a Resolver
1. Cómo es el código que permite decidir cómo se responderá la pregunta
2. Cómo asegura la extensibilidad del soporte para preguntas


## Solucion planteada
Aplicar el patron Strategy para resolver como  responder a alguna pregunta, en base a un patron de texto detectado por el ingreso del usuario. 
El objetivo de este repositorio es la ejemplificacion del patron Strategy , no la solucion completa al problema explicado.
