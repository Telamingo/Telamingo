import PersonalQuestions from "./PersonalQuestions";
import style from "./formQuestion.module.css"
import {useState} from "react";


const FormQuestions = (props) =>{
    const [isStart, setIsStart] = useState(false);
    return(
        <div className={`container mt-5 ${style.startForm}`}>
            {
                !isStart ? (
                    <div className={`row`}>
                        <h3>Welcome to Telamingo :)</h3>
                        <h5 className={'mt-3'}>Lets start with some question</h5>
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