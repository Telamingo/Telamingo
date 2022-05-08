import React from 'react';
import style from "./HomePage/homePage.module.css";

const Home =(props)=> {

    // const {isMobile} = props
return(
    <div className={`container col-lg-12 mt-5 ${style.homePage}`}>
        <div className={`row ${style.content}`}>
            <div className={`col-lg-6`}>
                <h1 >set aside the ambiguities with the most reliable rout</h1>
                <p >Telamingo helps you to set aside the ambiguities with
                    the most reliable route based on the experiences of the
                    people with the most similar conditions you have.
                </p>
                <div className={`col-lg-12 mt-5`}>
                    <div className={style.selectCountry}>
                        <input className={`col-lg-8`} placeholder="Where do you want to go?"/>
                        <button >Explore</button>
                    </div>
                </div>
            </div>
            <div>
                <img src="https://takhfifan.com/_next/static/images/Group%205172-1ed0859b45b3fa9b3170a69e9276d256.svg" alt="homePagePic"/>
            </div>
        </div>
    </div>
)
}
export default Home;
