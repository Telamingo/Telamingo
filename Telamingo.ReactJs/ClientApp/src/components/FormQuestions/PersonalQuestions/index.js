import React, {useState} from "react";
import style from "./personalQuestion.module.css";
import EconomyQuestions from "../EconomyQuestions";

const PersonalQuestions = (props) => {
    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [fifthQuestion, setFifthQuestion] = useState(false);
    const [haveFollower, setHaveFollower] = useState(false);
    // const [countOfFollowers, setCountOfFollowers] = useState(false);
    const [firstLanLevel, setFirstLanLevel] = useState("");
    const [firstLan, setFirstLan] = useState("");
    // const [answers, setAnswers] = useState("");

    const setAnswer=(id)=>{
        console.log(id)
        // var a = document.querySelector(".answer").innerHTML;
        // setAnswers([...answers,a])
    }
console.log(firstLan)
    return (
        <React.Fragment>
            {
                !fifthQuestion ? (
                    <div className={` col-lg-12 container ${style.questionBody}`}>
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                How old are you?
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => {setFirstQuestion(true);setAnswer(1)}}>Over 50 years</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>Between 35 and 49 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)} >Between 25 and 34 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)} > Between 18 and 24 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>Under 18 years</button>
                                            </div>
                                        </div>
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3  ${style.question}`}>
                                            <p className={`mt-3`}>
                                                What is your Sex?
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)} >Man</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}  >Woman</button>
                                            </div>
                                            <div>
                                                <button  onClick={() => setSecondQuestion(true)} >Other</button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setFirstQuestion(false)}>previous
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !thirdQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                Marital Status:
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)} >Single</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)} >Married</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)} >Seperated</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)} >Divorced</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)} >Widow</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Other</button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setSecondQuestion(false)}>previous
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !forthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                Language Status:
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.language : style.languageM}`}>
                                            <div className="mb-3">
                                                <label>
                                                    choose first language:
                                                    <select onChange={(event)=>setFirstLan(event.target.value)}>
                                                        <option selected>choose your first language</option>
                                                        <option>English</option>
                                                        <option>French</option>
                                                        <option>italian</option>
                                                    </select>
                                                </label>
                                                <label>
                                                    first language level:
                                                    <select
                                                        onChange={(event) => setFirstLanLevel(event.target.value)}>
                                                        <option selected>choose your level</option>
                                                        <option>Advance</option>
                                                        <option>Intermediate</option>
                                                        <option>Beginner</option>
                                                    </select>
                                                </label>
                                            </div>
                                            <div  className="mb-3">
                                                <label>
                                                    choose second language:
                                                    <select onChange={(event)=>setFirstLan(event.target.value)}>
                                                        <option selected>choose your first language</option>
                                                        <option>English</option>
                                                        <option>French</option>
                                                        <option>italian</option>
                                                    </select>
                                                </label>
                                                <label>
                                                    second language level:
                                                    <select
                                                        onChange={(event) => setFirstLanLevel(event.target.value)}>
                                                        <option selected>choose your level</option>
                                                        <option>Advance</option>
                                                        <option>Intermediate</option>
                                                        <option>Beginner</option>
                                                    </select>
                                                </label>
                                            </div>
                                            <div  className="mb-3">
                                                <label>
                                                    choose third language:
                                                    <select onChange={(event)=>setFirstLan(event.target.value)}>
                                                        <option selected>choose your first language</option>
                                                        <option>English</option>
                                                        <option>French</option>
                                                        <option>italian</option>
                                                    </select>
                                                </label>
                                                <label>
                                                    third language level:
                                                    <select
                                                        onChange={(event) => setFirstLanLevel(event.target.value)}>
                                                        <option selected>choose your level</option>
                                                        <option>Advance</option>
                                                        <option>Intermediate</option>
                                                        <option>Beginner</option>
                                                    </select>
                                                </label>
                                            </div>
                                            <div className={`${style.buttons}`}>
                                                <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                    <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                            onClick={() => setThirdQuestion(false)}>previous
                                                    </button>
                                                </div>
                                                {
                                                    firstLanLevel === "" ?
                                                        <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                            <button
                                                                className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                            </button>
                                                        </div>
                                                        :
                                                        <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                            <button
                                                                className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                onClick={() => setForthQuestion(true)}>next
                                                            </button>
                                                        </div>
                                                }
                                            </div>
                                        </div>
                                    </React.Fragment>
                                ) : !fifthQuestion &&
                                    <React.Fragment>
                                        {
                                            !haveFollower ? (
                                                <React.Fragment>
                                                    <div className={`mb-3 ${style.question}`}>
                                                        <p className={`mt-3`}>
                                                            Are you planning to immigrate alone?
                                                        </p>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.chooseCount : style.chooseCountM} mt-5 mb-5`}>
                                                        <div>
                                                            <button onClick={() => setFifthQuestion(true)}>Yes</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setHaveFollower(true)}>No</button>
                                                        </div>
                                                    </div>
                                                    <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                        <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                onClick={() => setForthQuestion(false)}>previous
                                                        </button>
                                                    </div>
                                                </React.Fragment>
                                            ) : (
                                                <React.Fragment>
                                                            <React.Fragment>
                                                                <div className={`mb-3 ${style.question}`}>
                                                                    <p className={`mt-3`}>
                                                                        How many person are be with you?
                                                                    </p>
                                                                </div>
                                                                <div className={`${!props.isMobile ? style.chooseCount : style.chooseCountM} mt-5 mb-5`}>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => setFifthQuestion(true)}>1
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => setFifthQuestion(true)}>2
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => setFifthQuestion(true)}>3
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => setFifthQuestion(true)}>4
                                                                        </button>
                                                                    </div>
                                                                </div>
                                                            </React.Fragment>
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                            }
                        </div>
                    </div>
                ) : (
                    <EconomyQuestions isMobile={props.isMobile}/>
                )
            }
        </React.Fragment>
    )
}
export default PersonalQuestions;