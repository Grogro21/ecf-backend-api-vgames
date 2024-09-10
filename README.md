# ecf-backend-api-vgames

## Contexte

La Gizmondo est une console de jeux vidéo portable faisant également office d'appareil photo, GPS, lecteur audio/vidéo... Elle fut fabriquée de 2005 à 2008 par Tiger Telematics.

### Spécifications techniques
- CPU : Samsung 400 MHz ARM9
- GPU : NVIDIA GoForce 3D 4500
- Mémoire graphique: 1.2MB 128-bit SRAM 
- RAM: 128 MB 16-bit DDR 200Mhz
- ROM: 64 MB 
- Affichage : écran TFT couleur de 2,8 pouces 
- Palette graphique : 65 536 couleurs
- Résolution : 240×320 pixels
- Son : stéréo
- Autonomie : 4h en mode jeu, 3h en mode film, 12h en mode audio et 100h en veille.
- Dimensions : 138 × 82 × 32 mm
- Poids : 150g
- Autres : bluetooth 2, lecteur MP3, système de localisation GPS, lecteur de cartes mémoire SD, SMS/MMS, appareil photo numérique.

## Préparation.

Faites un FORK du dépôt actuel du votre compte Github (pensez à bien décocher la case `Copy the main branch only` afin de récupérer toutes les branches du dépôt).

Cloner le dépôt en local et positionner vous dans la branche `asp`.

A l'aide de Visual Studio, créer un projet `ASP Web API` que vous nommerez `Ecf.Vgames`

Installer les packages et dépendances nécessaires.


## Travail à réaliser

Dans le dossier `public`, vous trouverez une page web `gizmondo.html` qui liste les jeux de la console Gizmondo.

Votre travail consiste à créer les entités de l'API qui permet de faire fonctionner la page web.

Dans le répertoire `public/assets/`, vous trouverez un fichier `GizmondoRepository.js` dans lequel vous devez modifier la valeur de la variable `apiUrl` (ligne 5) afin qu'elle corresponde à l'url de base de votre API. 

Rendez-vous dans les propriétés de votre projet ou démarrer votre projet API pour identifier l'URL de votre application.

Mise à part la modification demandée ci-dessus, vous ne devez, en aucun cas, modifier le code HTML, CSS ou JS présent dans les autres fichiers du dossier `public`. Toute modification de code sera éliminatoire !

2 entités sont attendues : 
- Gizmondo (accessible via l'url 'https://url.de.mon.api:port/gizmondos')
- Publisher (accessible via l'url 'https://url.de.mon.api:port/publishers')

Les données du jeu d'essai sont disponibles dans le répertoire `public/dataset/` du dépôt: 
- Au format SQL
- Au format JSON
