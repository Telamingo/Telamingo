import style from "./homePage.module.css";
import React from "react";
// import {Link} from "react-router-dom";
import {useState} from "react";

import homePagePic from "../../static/homePage/homePagePic.jpeg";
import FormQuestions from "../FormQuestions/index"

const HomePage = (props) =>{

    const countrys = [
        "Canada",
        "Us",
        "Italy",
        "France"
    ];
    const [country, setCountry]=useState()
    const [goToForm, setGoToForm]=useState(false)

    const {isMobile} = props

    return(
        <React.Fragment>
            {
                !goToForm ? (
                    <div className={`container col-lg-10 mt-5 ${style.homePage}`}>
                        <div className={`row  ${style.content}`}>
                            <div className={`col-lg-6`}>
                                <h1 className={`${ !isMobile ? style.content_title : style.content_titleM}`}>Set aside the ambiguities with the most reliable rout</h1>
                                <p className={`mt-4 ${!isMobile ? style.content_dsc : style.content_dscM}`}>Telamingo helps you to set aside the ambiguities with
                                    the most reliable route based on the experiences of the
                                    people with the most similar conditions you have.
                                </p>
                                <div className={`col-lg-12 mt-5`}>
                                    <div className={style.selectCountry}>
                                        <label className={style.chooseCountryLabel}>
                                            <select value={country} className={style.chooseCountrySelect}
                                                    onChange={(event) => setCountry(event.target.value)} required>
                                                <option value="انتخاب کشوراول" selected>Choose your country...</option>
                                                {
                                                    countrys.map(item => <option value={item}>{item}</option>)
                                                }
                                            </select>
                                        </label>
                                        {
                                            country ?
                                                <button className={`${!isMobile ? style.selectCountryButton:style.selectCountryButtonM}`} onClick={()=>setGoToForm(true)}>
                                                    Explore
                                                </button> :
                                                <button className={`${!isMobile ? style.selectCountryButtonDeactive:style.selectCountryButtonDeactiveM}`}>
                                                    Explore
                                                </button>
                                        }
                                    </div>
                                </div>
                            </div>
                            <div className={`${!isMobile ? `col-lg-6 ${style.homePagePic}` : `mt-3 ${style.homePagePicM}`}`}>
                                <img src={homePagePic} alt="homePagePic"/>
                            </div>
                        </div>
                    </div>
                ):(
                    <FormQuestions destination={country} isMobile={isMobile}/>
                )
            }
        </React.Fragment>
    )
}

export default HomePage;