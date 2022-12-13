# M17UF2R1-OlidAlejandro

```
# ROGUE CHAPUZAS

```

## Temática:
Quieres irte rapido a casa a jugar al Hades, para ello ayuda al equipo de obreros de tu padre.

Aparecerán dos tipos de obreros: Unos necesitan herramientas y te perseguiran, otros se quedarán quietos y te llamarán. Intenta no perder la paciencia, si no se acabará la partida.

Utiliza las herramientas que más te gusten y encuentres por el mapa.

## Inputs a través del Input System de Unity: 
- Movimiento [WASD  /Joystick Izquierdo]
- Apuntar [Ratón / Joystick Derecho]
- Disparar [Click Izquierdo / Botón Oeste]
- Dash (desplazamiento e inmunidad) [Espacio / Botón Sur]
- Seguimiento de los enemigos al jugador.

## Acciones que puedes realizar:
- Cambio de arma (colección de 5 armas)
- Ataque a distancia
- Recargar (automático, si es posible)
- Ataque Melee
- Destruccion de LootBoxes
- Eliminacion de enemigos
- Recoger objetos del suelo

## Enemigos: Perseguidor y torreta

## Mecánicas:
- Spawn de oleadas de enemigos aleatorios, controlada por un sistema de tiempo y coste/enemigo.
- Spawn de Loot al eliminar enemigos o LootBoxes.
- Condición de victoria: Eliminar a todos los enemigos.
- Condición de derrota: Vida del personaje a 0.
- Munición limitada.
- CoolDown de las herramientas.

## HUD:
- Barra de vida 
- Puntos por Enemigos derrotados 
- Puntos por monedas recogidas

## Escenario realizado con TileMaps, con elementos destruibles y no destruibles.

## Herencia:
clases de Characters, weapons y Loot

## Items:
- LootBoxes (Spawn de LootPrefabs aleatorios)
- LootPrefabs
- Weapon Holder
- Weapons Bullets

## Scriptable Objects:
- Weapons
- Bullets
- Loot

## GameManager:
Controla la condición de victoria y derrota

