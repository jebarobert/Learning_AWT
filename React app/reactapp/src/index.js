import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

function Employee(data) {
  return (<div><p>Name : {data.name}</p>
    <p>Salary : {data.salary}</p></div>);
}

const element = <Employee name="Sara" salary="12345" />;
const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>

    Hello World!
    <Employee name="Sara" salary="12345"/>

  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
