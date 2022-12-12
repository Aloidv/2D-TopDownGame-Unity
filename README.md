# M17UF2R1-OlidAlejandro

## Ayuda a los obreros proporcionandoles herramientas o ayuda,te recompensarán con monedas si les dejas ir antes...

```
# ROGUE CHAPUZAS

```

## Project info

Aquesta entrega es centra en crear un gameplay d’on parteix el nostre joc. Definició i verbs del player, animacions, verbs, items, armes, vida, enemics. Quant més preparada estigui aquesta base, més fàcil i més lluny es podrà arribar en el següent pas.
Llistat de punts a desenvolupar
R1.1 Personatge Jugador:
Moviment del jugador: moviment lliure en el pla. Animacions
Orientació del personatge segons posició del mouse (independent al moviment) 
Verbs:
Canvi d'arma: 
Col·lecció de fins a 5 armes.
Canvi d'arma: rodeta del mouse o X o C
Atac: segons l'arma a la que s'està
Distància: 
Direcció del tret: segons posició del punter del ratolí.
tipus de projectil i força segons l'arma
Número de projectils
Cadència de foc
Dash: 
Variable d'unitats d'avançament ràpid. Els enemics no fan mal durant el moviment de dash.
Ha de tenir un temps de Cooldown
Impuls en línia recta segons orientació  personatge



R1.2 Escenari, items i HUD
Barra de vida: 
Tamany segons la vida màxima que té el jugador
Mostra la vida actual
Punts: per impacte a un enemic, mort de l'enemic, per element agafat i pantalla realitzada
Escenari: 
Escenari en forma d'habitació o sala gran amb mínim dues portes. Ara tancades.

crear un escenari (prefab) de proves top down amb l'eina tilemap
Elements no destruïbles: murs, columnes. No deixen passar, no es poden destruir.
Elements destruïbles:
No deixen passar fins que són destruïts
Tenen un % de probabilitats que al destruir-se deixarà caure un item.
Items:
Arma: 
Crear Armes utilitzant herències.
Les armes item tenen un valor de bales.
Si s'agafa una arma que ja es té aumenta el número de bales.
Vida: kit de que suma vida. No suma vida si ja està al màxim.

R1.3 Enemics

Spawners: prefab que crea un determinat número d’enemics en un temps determinat. Crear aquest prefab amb intenció de utilització en el disseny de les sales del joc.


Enemics: 
Enemic 1: persegueix al personatge i explota al estar a prop
Enemic 2: torreta que dispara a l’enemic.


R1.4 Gameplay
Gameplay:
Personatge comença amb arma a distància. Munició limitada
Apareixen N enemics en un interval de temps finit.
Al morir tots els enemics esperats: joc terminat, mostrem punts


R1.5 Requisits generals
Realització de mínim 1 Manager de tipus Singleton.
Implementació de màquines d’estats, mínim 1
Es pot realitzar amb enums i switch
(Bonus) Fer servir el patró State
Emprar herència e interfaces de classes.
Es recomana en components comuns per personatges, enemics, items i armes.
Realitzar diagrama de classes i variables/propietats




La temàtica i estètica és lliure sempre i quan es respecti:
Dimensions 2D
Estètica cartoon, pixelart o similars


Documentació:
Omplir el readme del git amb un redactat del sentit del vostre joc, fitxa tècnica i instruccions del joc (comandament, tecles, etc)

Es pot fer servir recursos de tercers sempre i quan es respecti els seus drets d’ús. També es poden fer servir recursos propis.

Nota: en aquesta carpeta teniu una llibreria d’imatges d’elements de UI’s adquirits per l’Institut que podeu utilitzar lliurement. Són fitxer tipus zip on els elements han sigut reunits per estils.
	Repositori de UI’s
	Full resum de les UI’s

Tots aquests elements seran utilitzats més endavant en un joc més gran. Per tant dissenyeu la seva arquitectura i codi pensant en escalabilitat i level design. En aquest punt feu ús correcte de l'accessibilitat a les variables.

Bonus
(Bonus) recarregar l’arma
(Bonus)Melee:
Area d'impacte a 4 quadrants: nord, sud, est, oest. 
A l’ impactar amb un enemic l'impulsa enrere. Força segons l'arma
Segons l'arma té una cadència d'atac
(Bonus) Dash +  Atac: atac amb dany extra en tot enemic tocat.
(Bonus) Temàtica i mecàniques encarades a un context social, conscienciació i/o no violent.
(Bonus) La creació d’enemics feta en forma d’onades. Es prega ser coherent amb les variables per dissenyar les onades.
(Bonus) Aquestes onades d’enemics tenen % de probabilitat per aconseguir una varietat de creació.
(Bonus) Realitzar diagrames de flux i de casos d’ús de com funciona el vostre joc.
(Bonus) Ús coherent de mínim 1 ScriptableObject: definició, creació i ús.
(Bonus) Tot element destruible te % de probabilitats per deixarà caure un item
(Bonus) Implementació de la interactuació amb el nou Input System de Unity
(Bonus) Interactuació amb el joc a través d’un comandament tipo xbox, playstation, etc.
(Bonus) introducció del personatge al nivell (animació)

Format d’entrega
	
Entrega en repositori GIT en el núvol. 
Nom del projecte: M17UF2R1-CognomsNom
Documentació en el Readme del projecte.
Imatges o document de recull de recursos (diagrames) amb el mateix format de nom que el projecte.
Commit a la branca master a la plataforma GITLAB amb nom: RogueLike1 - Entrega

