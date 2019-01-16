Introduction
====

L'université Contoso utilise une application pour enregistrer ses enseignants ainsi que les étudiants qui souhaitent suivre des cours.

A l'université de Contoso, la qualité est une préoccupation de tous les instants. Pour assurer un maximum de qualité, tous les développements sont revues, testés par les pairs puis réintégré.

![Le process en image](https://g.gravizo.com/svg?digraph%20G%20{node%20[shape=];Dev->"Code%20Review"->QA->Integration})

L'université à un objectifs de 80% de couverture de code pour tous les nouveaux developpements, ces mesures seront obtenues à l'aide des outils disponibles dans VisualStudio.

## Charte graphique

## Mise en place de l'environnement de développement
Chaque équipe doit créer son repository sur GitHub et creer un fork du repository où se trouve l'ennoncé que vous êtes en train de lire.
Pour compiler la solution il vous faudra les prérequis suivants :
* Visual Studio 2015 ou 2017
* LocalDB version 12 (SQL Server 2014) [lien](https://download.microsoft.com/download/E/A/E/EAE6F7FC-767A-4038-A954-49B8B05D04EB/LocalDB%2064BIT/SqlLocalDB.msi)
* Une instance localDB nommé **MSSQLLocalDB**

> Procédures :
> * [Configuration de LocalDB](setupEnvironment/LocalDBSetup.MD)
> * [Initialisation de la base de donnée](setupEnvironment/DatabaseSetup.MD)


## Les points à soutenir
* Les stories que vous aurez implémenté
* Le design ainsi que l'ergonomie que vous aurez mis en place
* Le process mis en place au sein de votre equipe afin d'assurer la qualité du code et du produit
* Organisation et utilisation du source control
* L'organisation du suivi de la réalisation des tâches


