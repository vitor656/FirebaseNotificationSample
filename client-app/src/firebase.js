import firebase from 'firebase';
import data from './key.json';

const config = data;

firebase.initializeApp(config);
firebase.analytics();

export default firebase;