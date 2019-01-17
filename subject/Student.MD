Students
====

## Story 1 - Inscription à un cours
### Description
Un étudiant doit pouvoir s'inscrire à un cours via l'interface

L'application gère les inscriptions des étudiants aux cours mais ne propose pas d'interface graphique pour les étudiants puissent le faire eux même.
Sur la page de détail d'un étudiant, ajouter la possibilité de souscrire à un cours.

### Acceptance Criterias
* Il n'est pas possible pour un étudiant de se désinscrire à un cours
* Si l'étudiant est déjà inscrit, afficher le message d'erreur "You already subscribed to this lesson"
* Si l'étudiant s'inscrit à un cours, il est inscrit à toutes les occurences

---

## Story 2 - Upload d'une photo de profile étudiant
### Description
Les étudiants peuvent uploader une photo sur leur profile

### Acceptance Criterias
* Une seule photo de profile est autorisé à la fois
* L'image de doit pas excéder 100 KB
* Les formats autorisés sont le *png* et *jpeg*
* La photo est visible sur le detail de leur profile

---

## Story 3 - Créer une page d'accueil pour les étudiants
### Description
Pour améliorer l'ergonomie de l'application, nous souhaitons mettre en place une page d'accueil spécifique pour les étudiants.

Cette page devra afficher les cours auxquels l'étudiant connecté s'est inscrit, sous la forme d'un agenda de la semaine.

L'affichage de l'agenda aura les caractéristiques suivantes :
* Présentation des 5 jours de la semaines : Lundi au Vendredi
* Présentation dans un style outlook des créneaux horaires des cours
* Chaque créneau de cours devra afficher le libellé du cours

### Acceptance Criterias
* L'agenda devra être celui de l'étudiant connecté
* L'affichage aura une granularité à l'heure
