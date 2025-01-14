import { Route, Routes } from 'react-router-dom'
import MainPage from '../pages/MainPage';
import SecondPage from '../pages/SecondPage';
import ErrorPage from '../pages/ErrorPage';
import ThirdPage from '../pages/ThirdPage';
import Plotly2d from '../pages/Plotly2d';
import Plotly3d from '../pages/Plotly3d';
import Task from '../pages/Task';

const Router = () => {
  return (
    <Routes>
        <Route path="/" index element={<MainPage />} />
        <Route path="/second" index element={<SecondPage />} />
        <Route path="*" element={<ErrorPage />} />
        <Route path="/third" element={<ThirdPage />} />
        <Route path="/plotly2d"  element={<Plotly2d />} />
        <Route path="/plotly3d"  element={<Plotly3d />} /> 
        <Route path="/task"  element={<Task />} />
    </Routes>
  );
};

export default Router;
