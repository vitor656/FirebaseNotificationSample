/* eslint-disable no-undef */
// eslint-disable-next-line no-undef
importScripts('https://www.gstatic.com/firebasejs/8.8.0/firebase-app.js');
importScripts('https://www.gstatic.com/firebasejs/8.8.0/firebase-messaging.js');


firebase.initializeApp({
    apiKey: "AIzaSyCiqxXtXbp3XIpe8gPrSFCzCFcLuv-vN_g",
    authDomain: "fir-notificationsample-c298c.firebaseapp.com",
    projectId: "fir-notificationsample-c298c",
    storageBucket: "fir-notificationsample-c298c.appspot.com",
    messagingSenderId: "1041298332640",
    appId: "1:1041298332640:web:0b6c212a0872c6faafe985",
    measurementId: "G-DF2MCBW28D"
});

const messaging = firebase.messaging();

messaging.onBackgroundMessage(function(payload) {
  console.log('Received background message ', payload);

  const notificationTitle = payload.notification.title;
  const notificationOptions = {
    body: payload.notification.body,
  };

  self.registration.showNotification(notificationTitle,
    notificationOptions);
});
