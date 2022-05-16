import PersonalQuestions from "./PersonalQuestions";
import style from "./formQuestion.module.css"
import {useState} from "react";
import React from "react";

import HomePagePic from "../../static/homePage/homePagePic.jpeg"

const FormQuestions = (props) =>{
    const [isStart, setIsStart] = useState(false);
    return(
        <div className={`container col-12 mt-5 `}>
            {
                !isStart ? (
                    <div className={`row ${style.startForm}`}>
                        <h3>Welcome to Telamingo</h3>
                        <h5 className={'mt-3'}>Lets start with some question</h5>
                        <div className={`${!props.isMobile ? `mt-5 col-lg-12 ${style.startPagePic}` : `mt-3 ${style.startPagePicM}`}`}>
                            <img src={HomePagePic} alt="homePagePic"/>
                        </div>
                        <button className={`container mt-5 ${style.startFormButton}`} onClick={()=>setIsStart(true)}>Start</button>
                    </div>
                ) : (
                    <PersonalQuestions isMobile={props.isMobile}/>
                )
            }
        </div>
    )
}

export default FormQuestions