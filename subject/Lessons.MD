Lessons
====

## Story 1 - Horaires des cours - 1 occurance par semaine
### Description
On souhaite pouvoir gerer les emplois du temps des étudiants et des professeurs grace à l'application, mais pour cela il faut que l'application puisse connaitre les dates et les horaires de cours.

Pour cette première version nous n'allons traiter que les cours qui interviennent de façon hebdomadaire.

### Acceptance Criterias
* Sélection du jour de la semaine
* Heure du cours
* Durée du cours

---

## Story 2 - Horaires des cours - multiple occurances par semaine
### Description
L'application doit pouvoir programmer des cours qui peuvent avoir une frequence de plusieurs fois par semaine.

### Acceptance Criterias
* Un cours peut avoir lieu plusieurs fois dans la semaine avec des horaires et des durées differentes
* Un cours peut avoir lieu plusieurs fois dans la même journée avec des durées différentes

---

## Story 3 - Controle à l'inscription de cours
### Description
Lorsqu'un étudiant s'inscrit à cours, l'application doit s'assurer que son emploi du temps le permet.

Un étudiant ne peut pas s'inscrire à un cours s'il est déjà inscrit à un cours qui se tient sur la même plage horaire.

### Acceptance Criterias
* Autoriser l'inscription à des cours ayant des horaires qui ne se chevochent pas
* Refuser l'inscription à des cours ayant des horaires qui se chevochent
