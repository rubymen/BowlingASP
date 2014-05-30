# Application de gestion (ASP.Net MVC)
Le projet Bowling a entièrement été conçu sous versioning Git avec une architecture gitflow

Vous avez donc accès aux sources via cette adresse : https://github.com/rubymen/BowlingASP

## Téléchargement du projet
Afin de télécharger le projet, accédez à cette adresse : https://github.com/rubymen/BowlingASP/archive/develop.zip

## Installation
Installer et/ou ouvrir Visual Studio 2012.
Lancez le projet. La référence du webservice SOAP est déjà ajoutée (http://bowling.noip.me/)

Le code est commenté.

## Utilisation
* La vue index (/) présente la liste des parties :

    * L'affichage des parties de bowling (Id, joueurs associés, statut, le numéro de piste, date, actions disponibles en fonction du statut),
    * Possiblité de consulter, annuler ou démarrer une partie,
    * Filtrer par statut ou par date (au format JJ-MM-AAAA).

* La vue de création (/Game/Create):

    * Permet de créer une partie et d'ajouter des joueurs à celle-ci

* La vue de modification (/Game/Edit/{Id})

    * Permet la modification des pseudos des joueurs de la partie séléctionnée,
    * Permet la suppression de joueurs.

* La vue de visualisation (/Game/Show/{Id})

    * Permet la visualisation des scores d'une partie en cours.

Note : La partie 1 est en cours et permet d'avoir un aperçu de l'affichage des points.
