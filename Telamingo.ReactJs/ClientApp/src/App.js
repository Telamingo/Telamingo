import React, { useState, useEffect } from 'react';
import { Route } from 'react-router';
import Layout from "./components/layout/index"
import HomePage from "./components/HomePage";

import './custom.css'
import FormQuestions from "./components/FormQuestions";


const App = () => {

    const [isMobile, setIsMobile] = useState(false)

    useEffect(() => {
        window.addEventListener("resize", handleResize)
    })

    const handleResize = () => {
        if (window.innerWidth < 720) {
            setIsMobile(true)
        } else {
            setIsMobile(false)
        }
    }
    return (
        <div>
            <Layout isMobile={isMobile}>
                <Route path='/form'><FormQuestions isMobile={isMobile} /></Route>
                <Route exact path='/'> <HomePage isMobile={isMobile}/> </Route>
            </Layout>
        </div>
    );
}
export default App;
