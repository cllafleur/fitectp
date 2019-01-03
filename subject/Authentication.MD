Authentication
====

## Story 1 -Authentification de l'utilisateur

### Description
L'utilisateur doit pouvoir s'authentifier pour accéder à l'application

Afficher une page qui permet de saisir :
* Login
* Mot de passe

### Acceptance Criterias
* Si le login et le mot de passe sont correctes l'utilisateur se connecte et redirigé sur la page d'acceuille
* Si le login et le mot de passe sont incorrects afficher un message "Invalid login or password"

---

## Story 2 - Création de compte

### Description
L'utilisateur doit pouvoir se créer un compte sur l'application

Afficher une page qui permet de creer un compte avec les champs suivants:
* Login
* Mot de passe
* Type d'utilisateur (Student/Instructor)

### Acceptance Criterias
* Si tous les champs sont renseignés et le login n'existe pas, le compte est créé
* Si les champs ne sont pas remplis afficher un message d'erreur et indiquer ceux qui doivent etre renseignés
* Si le login existe déjà en base, afficher un message d'erreur "This login already exists"
