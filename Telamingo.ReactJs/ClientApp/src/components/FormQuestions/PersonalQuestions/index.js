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
    const [firstLang, setFirstLang] = useState(false);
    const [secondLang, setSecondLang] = useState(false);
    const [thirdLang, setThirdLang] = useState(false);
    const [firstLanLevel, setFirstLanLevel] = useState("");
    const [personalAnswers, setPersonalAnswers] = useState("");

    const language = [
        {
            value: "English",
            label: "English",
            id:1
        },
        {
            value: "French",
            label: "French",
            id:2
        },
        {
            value: "Italian",
            label: "Italian",
            id:3
        },
    ]

    const setAnswer=(answer)=>{
        setPersonalAnswers([...personalAnswers,answer])
    }
    console.log(personalAnswers)

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
                                                <button onClick={() => {setFirstQuestion(true);setAnswer("Over 50 years")}}>Over 50 years</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("Between 35 and 49 years")
                                                }}>Between 35 and 49 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("Between 25 and 34 years")
                                                }} >Between 25 and 34 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer(" Between 18 and 24 years")
                                                }} > Between 18 and 24 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("Under 18 years")
                                                }}>Under 18 years</button>
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
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer("Man")
                                                }} >Man</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer("Woman")
                                                }}  >Woman</button>
                                            </div>
                                            <div>
                                                <button  onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer("Other")
                                                }} >Other</button>
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
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("single")
                                                }} >Single</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Married")
                                                }} >Married</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Seperated")
                                                }} >Seperated</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Divorced")
                                                }} >Divorced</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Widow")
                                                }} >Widow</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Other")
                                                }}>Other</button>
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
                                            {
                                                !firstLang ? (
                                                       <React.Fragment>
                                                           <div className="mb-3">
                                                               <label onChange={(e)=>setAnswer(e.target.value)}>
                                                                   Choose First Language:
                                                                   <select>
                                                                       <option selected>Choose Your First Language</option>
                                                                       {
                                                                           language.map((lang)=>(
                                                                               <option value={lang.value} key={lang.id}>{lang.label}</option>
                                                                           ))
                                                                       }
                                                                   </select>
                                                               </label>
                                                               <label onChange={(e)=>setAnswer(e.target.value)}>
                                                                   First Language Level:
                                                                   <select onChange={(event) => setFirstLanLevel(event.target.value)}>
                                                                       <option selected>Choose Your Level</option>
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
                                                                               onClick={() => setFirstLang(true)}>next
                                                                           </button>
                                                                       </div>
                                                               }
                                                           </div>
                                                       </React.Fragment>
                                                ) : !secondLang ? (
                                                    <React.Fragment>
                                                        <div  className="mb-3">
                                                            <label onChange={(e)=>setAnswer(e.target.value)}>
                                                                Choose Second Language:
                                                                <select>
                                                                    <option selected>Choose Your First Language</option>
                                                                    {
                                                                        language.map((lang)=>(
                                                                            <option value={lang.value} key={lang.id}>{lang.label}</option>
                                                                        ))
                                                                    }
                                                                </select>
                                                            </label>
                                                            <label onChange={(e)=>setAnswer(e.target.value)}>
                                                                Second Language Level:
                                                                <select>
                                                                    <option selected>Choose Your Level</option>
                                                                    <option>Advance</option>
                                                                    <option>Intermediate</option>
                                                                    <option>Beginner</option>
                                                                </select>
                                                            </label>
                                                        </div>
                                                        <div className={`${style.buttons}`}>
                                                            <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                                <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                        onClick={() => setFirstLang(false)}>previous
                                                                </button>
                                                            </div>
                                                            <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                <button
                                                                    className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => setSecondLang(true)}>next
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </React.Fragment>
                                                ) : !thirdLang ? (
                                                    <React.Fragment>
                                                        <div  className="mb-3">
                                                            <label onChange={(e)=>setAnswer(e.target.value)}>
                                                                Choose Third Language:
                                                                <select>
                                                                    <option selected>Choose Your First Language</option>
                                                                    {
                                                                        language.map((lang)=>(
                                                                            <option value={lang.value} key={lang.id}>{lang.label}</option>
                                                                        ))
                                                                    }
                                                                </select>
                                                            </label>
                                                            <label onChange={(e)=>setAnswer(e.target.value)}>
                                                                Third Language Level:
                                                                <select>
                                                                    <option selected>Choose Your Level</option>
                                                                    <option>Advance</option>
                                                                    <option>Intermediate</option>
                                                                    <option>Beginner</option>
                                                                </select>
                                                            </label>
                                                        </div>
                                                        <div className={`${style.buttons}`}>
                                                            <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                                <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                        onClick={() => setSecondLang(false)}>previous
                                                                </button>
                                                            </div>
                                                            <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                <button
                                                                    className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => setForthQuestion(true)}>next
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </React.Fragment>
                                                ) : null
                                            }
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
                                                            <button onClick={() => {
                                                                setFifthQuestion(true)
                                                                setAnswer("0")
                                                            }}>Yes</button>
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
                                                                            onClick={() => {
                                                                                setFifthQuestion(true);
                                                                                setAnswer("1")
                                                                            }}>1
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => {
                                                                                setFifthQuestion(true);
                                                                                setAnswer("2")
                                                                            }}>2
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => {
                                                                                setFifthQuestion(true);
                                                                                setAnswer("3")
                                                                            }}>3
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => {
                                                                                setFifthQuestion(true);
                                                                                setAnswer("4")
                                                                            }}>4
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
                    <EconomyQuestions isMobile={props.isMobile} personalAnswers={personalAnswers}/>
                )
            }
        </React.Fragment>
    )
}
export default PersonalQuestions;