Introduction
====

L'université Contoso utilise une application pour enregistrer ses enseignants ainsi que les étudiants qui souhaitent suivre des cours.

A l'université de Contoso, la qualité est une préoccupation de tous les instants. Pour assurer un maximum de qualité, tous les développements sont revues, testés par les pairs puis réintégré.

![Le process en image](https://g.gravizo.com/svg?digraph%20G%20{node%20[shape=];Dev->"Code%20Review"->QA->Integration})

## Charte graphique


## Mise en place de l'environnement de développement
Chaque équipe doit créer son repository sur GitHub et creer un fork du repository où se trouve l'ennoncé que vous êtes en train de lire.
Pour compiler la solution il vous faudra les prérequis suivants :
* Visual Studio 2015 ou 2017
* LocalDB version 12 (SQL Server 2014) [lien](https://download.microsoft.com/download/E/A/E/EAE6F7FC-767A-4038-A954-49B8B05D04EB/LocalDB%2064BIT/SqlLocalDB.msi)
* Une instance localDB nommé **MSSQLLocalDB**

> Procédures :
> * [Configuration de LocalDB](subject/setupEnvironment/LocalDBSetup.MD)
> * [Initialisation de la base de donnée](subject/setupEnvironment/DatabaseSetup.MD)


## Les points à soutenir
* Les stories que vous aurez implémenté
* Le design ainsi que l'ergonomie que vous aurez mis en place
* Le process mis en place au sein de votre equipe afin d'assurer la qualité du code et du produit
* Organisation et utilisation du source control
* L'organisation du suivi de la réalisation des tâches



# Liste des epics

* [API](subject/API.MD)
* [Authentication](subject/Authentication.MD)
* [HomePage](subject/HomePage.MD)
* [Instructors](subject/Instructors.MD)
* [Lessons](subject/Lessons.MD)
* [Student](subject/Student.MD)

# Prioritized Backlog

|Epic|Story|
|-|-|
Authentication|[Story 1 - Authentification de l'utilisateur](subject/Authentication.MD#Story-1---Authentification-de-l'utilisateur)|
|Student|[Story 1 - Inscription à un cours](subject/Student.MD#Story-1---Inscription-à-un-cours)|
|Student|[Story 2 - Upload d'une photo de profile étudiant](subject/Student.MD#Story-2---Upload-d'une-photo-de-profile-étudiant)|
|Authentication|[Story 2 - Création de compte](subject/Authentication.MD#Story-2---Création-de-compte)|
|Lessons|[Story 1 - Horaires des cours - 1 occurrence par semaine](subject/Lessons.MD#Story-1---Horaires-des-cours---1-occurrence-par-semaine)|
|API|[Story 1 - api Etudiants](subject/API.MD#Story-1---api-Etudiants)|
|Lessons|[Story 2 - Horaires des cours - multiple occurrences par semaine](subject/Lessons.MD#Story-2---Horaires-des-cours---multiple-occurrences-par-semaine)|
|HomePage|[Story 1 - Nouvelle Page d'accueil - Accès anonyme](subject/HomePage.MD#Story-1---Nouvelle-Page-d'accueil---Accès-anonyme)|
|HomePage|[Story 2 - Indexation par les moteurs de recherche](subject/HomePage.MD#Story-2---Indexation-par-les-moteurs-de-recherche)|
|Lessons|[Story 3 - Contrôle à l'inscription de cours](subject/Lessons.MD#Story-3---Contrôle-à-l'inscription-de-cours)|
|API|[Story 2 - api professeurs](subject/API.MD#Story-2---api-professeurs)|
|Instructors|[Story 1 - Upload d'une photo de profile professeur](subject/Instructors.MD#Story-1---Upload-d'une-photo-de-profile-professeur)|
|Student|[Story 3 - Créer une page d'accueil pour les étudiants](subject/Student.MD#Story-3---Créer-une-page-d'accueil-pour-les-étudiants)|
|Instructors|[Story 3 - Créer une page d'accueil pour le professeur connecté](subject/Instructors.MD#Story-3---Créer-une-page-d'accueil-pour-le-professeur-connecté)|
