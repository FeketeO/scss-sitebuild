* {
  box-sizing: border-box;
  padding: 0;
  margin: 0;
  border: 0;
}

html {
  scroll-behavior: smooth;
}

.head {
  font-family: Arial, Helvetica, sans-serif;
  color: yellow;
}

body {
  font-family: Arial, Helvetica, sans-serif;
  margin: 0;
}

h1 {
  font-family: "Catamaran", Helvetica, Arial, sans-serif;
  font-weight: 100;
}

.nav {
  display: flex;
  justify-content: center;
}
.nav__bootstrapc {
  align-items: flex-start;
  display: flex;
}
.nav__bootstrapc-btn {
  color: #df9c1e;
  border: none;
  background: none;
  padding: 1% 0% 0% 20%;
  max-width: 100%;
}
.nav__bootstrapc-btn:hover {
  color: #f7f2f2;
}
.nav__container {
  align-items: flex-end;
  display: flex;
  width: 100%;
  float: right;
}
@media screen and (min-width: 992px) {
  .nav__container {
    align-items: center;
  }
}
.nav__menu {
  display: none;
  flex-direction: column;
  list-style: none;
  margin: 0 auto;
  padding: 0;
  width: 100%;
}
@media screen and (min-width: 992px) {
  .nav__menu {
    display: flex;
    flex-direction: row;
    width: auto;
  }
}
.nav__item {
  text-align: center;
}
.nav__link {
  color: #222;
  display: block;
  line-height: 1rem;
  padding: 1rem;
  text-decoration: none;
}
.nav__link:hover {
  color: #efefef;
}
.nav__hamburger-checkbox {
  display: none;
}
.nav__hamburger-checkbox:checked + ul {
  display: flex;
}
.nav__hamburger--label {
  align-items: center;
  cursor: pointer;
  display: flex;
  flex-wrap: wrap;
  height: 1.5rem;
  padding: 0.75rem;
  width: 1.5rem;
}
@media screen and (min-width: 640px) {
  .nav__hamburger--label {
    display: none;
  }
}
.nav__hamburger--label--line {
  background-color: #222;
  display: block;
  height: 2px;
  width: 1.5rem;
}

.newage {
  display: flex;
  justify-content: center;
  align-items: center;
  background-image: url(/src/assests/img/bg-pattern.png), linear-gradient(to right, #da2431, #7a4397);
  background-repeat: repeat;
}
.newage__container {
  display: flex;
}
.newage__text {
  max-width: 30%;
  padding: 15% 0% 5% 8%;
}
.newage__text-ad {
  color: #fcf6f6;
  font-size: 2em;
  font-weight: light;
  padding: 15px;
}
.newage__text-btn {
  border-radius: 40px;
  padding: 10px 30px;
  font-family: Lato, Helvetica, Arial, sans-serif;
  font-size: 0.7em;
  color: white;
  background: none;
}
.newage__text-btn:hover {
  color: #3c3c3c;
  background-color: #fdcc52;
  border: 2px solid #fdcc52;
  cursor: pointer;
}
.newage__img {
  min-height: 70%;
  width: 40%;
}
@media screen and (min-width: 992px) {
  .newage__img {
    min-height: 50%;
    width: 35%;
  }
}
.newage__img-mobile {
  display: block;
  width: 50%;
  padding-bottom: 130%;
  background-size: 90%, contain;
  background-repeat: no-repeat, no-repeat;
  background-position: center, center;
  float: right;
  background-image: url(/src/assests/img/demo-screen-1.jpg), url(/src/assests/img/phone.png);
}

.discover {
  display: flex;
  background-color: #fdcc52;
  width: 100%;
  height: 100%;
}
.discover__conatiner {
  justify-content: center;
  align-items: center;
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  padding: 50%;
}
.discover__conatiner-ad {
  font-size: 6em;
}
.discover__googleplay {
  max-width: 40px;
}

/*# sourceMappingURL=style.cs.map */
