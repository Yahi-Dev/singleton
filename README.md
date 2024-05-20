Resumen del programa de gestión de familias
El programa de gestión de familias es una aplicación que permite modelar familias. De las familias se maneja su apellido. Las familias tienen una mascota, de la cual se maneja la especie (pez, gato, perro, conejo, etc.) y el nombre.

El programa puede manejar una cantidad "N" de familias, pero solo una mascota por familia. Para lograr esto último, se aplica el patrón de diseño Singleton.

Patrón de diseño Singleton

El patrón de diseño Singleton es un patrón de diseño creacional que asegura que una clase tenga solo una instancia, y proporciona un punto de acceso global a ella.

En este caso, la clase Singleton se utiliza para garantizar que solo haya una instancia de la familia actual. Esto es necesario para evitar que una familia tenga más de una mascota.

Funcionamiento del programa

El programa funciona de la siguiente manera:

El usuario crea una nueva familia.
El usuario selecciona la especie de la mascota.
El usuario introduce el nombre de la mascota.
El programa guarda la información de la familia y la mascota.
El usuario puede crear más familias y mascotas.
El usuario puede ver la información de las familias y las mascotas.
