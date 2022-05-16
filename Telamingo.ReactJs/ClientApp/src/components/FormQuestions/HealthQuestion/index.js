import React, {useEffect, useState} from "react";
import style from "./healthQuestion.module.css";
import MentalHealth from "../MentalHealth";

const HealthQuestion = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [haveASick, setHaveASick] = useState(false);
    const [haveFoodLife, setHaveFoodLife] = useState(false);
    const [firstSick, setFirstSick] = useState("");
    const [secondSick, setSecondSick] = useState("");
    const [thirdSick, setThirdSick] = useState("");
    const [illness, setIllness] = useState("");
    const [firstMealRate, setFirstMealRate] = useState(false);
    const [secondMealRate, setSecondMealRate] = useState(false);
    const [thirdMealRate, setThirdMealRate] = useState(false);
    const [healthAnswer, setHealthAnswer] = useState("");

    const getFirstSickVal =(e)=>{
        setFirstSick(e.target.value)
    }
    const getSecondSickVal =(e)=>{
        setSecondSick(e.target.value)
    }
    const getThirdSickVal =(e)=>{
        setThirdSick(e.target.value)
    }

    const combineIllness=  ()=>{
         setIllness([...illness,firstSick,secondSick,thirdSick])
    }

    useEffect(()=>{
        setAnswer(illness)
    },[illness])

    const setAnswer=(answer)=>{
        setHealthAnswer([...healthAnswer,answer])
    }

    // if(healthAnswer.length>=6){
    //     console.log(healthAnswer[healthAnswer.length-3])
    // }
    console.log(healthAnswer)


    return (
        <React.Fragment>
            {
                !forthQuestion ? (
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p>
                                                How often do you see a doctor?
                                            </p>
                                        </div>
                                        <div className={` ${style.chooseSickRate} mt-3`}>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("I rarely see a doctor / I rarely need a doctor")
                                                }}>I rarely see a doctor / I rarely need a doctor
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("I see a doctor for periodic checkups")
                                                }}>I see a doctor for periodic checkups
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("Due to certain diseases, I have to see a doctor regularly")
                                                }}>Due to certain diseases, I have to see a doctor regularly
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("I usually need a doctor urgently")
                                                }}>
                                                    I usually need a doctor urgently
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("I only go to traditional medicine doctors")
                                                }}>I only go to traditional medicine doctors
                                                </button>
                                            </div>
                                        </div>
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        {
                                            !haveASick ? (
                                                <React.Fragment>
                                                    <div className={`mb-3 ${style.question}`}>
                                                        <p>
                                                            Do you have a specific illness?
                                                        </p>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.chooseHaveSick : style.chooseHaveSickM} mt-3 ${!props.isMobile ? " ":`row`}`}>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer(false)
                                                            }}>No</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setHaveASick(true);
                                                                setAnswer(true)
                                                            }}>Yes</button>
                                                        </div>
                                                    </div>
                                                    <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                        <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                onClick={() => setFirstQuestion(false)}>previous
                                                        </button>
                                                    </div>
                                                </React.Fragment>
                                            ) : (
                                                <React.Fragment>
                                                    <div className={`${!props.isMobile ? style.chooseSick:style.chooseSickM} mt-5 mb-5`}>
                                                        <div className={`mb-3 ${style.question}`}>
                                                            <p>
                                                               your illness :
                                                            </p>
                                                        </div>
                                                        <div className="mt-5">
                                                            <div className="mb-3">
                                                                <label>First illness:</label>
                                                                <input type="text" onChange={getFirstSickVal}/>
                                                            </div>
                                                            <div className="mb-3">
                                                                <label>Second illness:</label>
                                                                <input type="text" onChange={getSecondSickVal}/>
                                                            </div>
                                                            <div className="mb-3">
                                                                <label>Third illness:</label>
                                                                <input type="text" onChange={getThirdSickVal}/>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div className={`${style.buttons}`}>
                                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => setFirstQuestion(false)}>previous
                                                            </button>
                                                        </div>
                                                        {
                                                            firstSick === "" ?
                                                                <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                    <button
                                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                                    </button>
                                                                </div>
                                                                :
                                                                <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                    <button
                                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                        onClick={() => {
                                                                            setSecondQuestion(true);
                                                                            combineIllness();
                                                                        }}>next
                                                                    </button>
                                                                </div>
                                                        }
                                                    </div>
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                                ) : !thirdQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p>
                                                How much do you expect your annual medical expenses to cost after emigrating?
                                                (Insurance costs plus treatment costs outside of insurance coverage)
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.chooseHaveSick : style.chooseHaveSickM} mt-3 ${!props.isMobile ? " ":`row`}`}>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Over $ 10,000")
                                                }}>Over $ 10,000</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Between $ 5,000 and $ 10,000")
                                                }}>Between $ 5,000 and $ 10,000
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Between $ 2,000 and $ 5,000")
                                                }}>Between $ 2,000 and $ 5,000
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Between $ 1,000 and $ 2,000")
                                                }}>Between $ 1,000 and $ 2,000
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Less than $ 1,000")
                                                }}>Less than $ 1,000
                                                </button>
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
                                        {
                                            haveFoodLife ?
                                                !firstMealRate ? (
                                                <div className={`mt-3 mb-5 ${!props.isMobile?style.mealHoby:style.mealHobyM}`}>
                                                    <div>
                                                        <label>Traditional dishes of my country:</label>
                                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstMealRate(true);
                                                                    setAnswer("0")
                                                                }}>0
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstMealRate(true);
                                                                    setAnswer("1")
                                                                }}>1
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstMealRate(true);
                                                                    setAnswer("2")
                                                                }}>2
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstMealRate(true);
                                                                    setAnswer("3")
                                                                }}>3
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstMealRate(true);
                                                                    setAnswer("4")
                                                                }}>4
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstMealRate(true);
                                                                    setAnswer("5")
                                                                }}>5
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            ) : !secondMealRate ? (
                                                <div className={`mt-3 mb-5 ${style.mealHoby}`}>
                                                    <div>
                                                        <label>Fast Food:</label>
                                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondMealRate(true);
                                                                    setAnswer("0")
                                                                }}>0
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondMealRate(true);
                                                                    setAnswer("1")
                                                                }}>1
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondMealRate(true);
                                                                    setAnswer("2")
                                                                }}>2
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondMealRate(true);
                                                                    setAnswer("3")
                                                                }}>3
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondMealRate(true);
                                                                    setAnswer("4")
                                                                }}>4
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondMealRate(true);
                                                                    setAnswer("5")
                                                                }}>5
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div className={`${style.buttons}`}>
                                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => setFirstMealRate(false)}>previous
                                                            </button>
                                                        </div>
                                                    </div>
                                                </div>
                                            ) : !thirdMealRate && (
                                                <div className={`mt-3 mb-5 ${style.mealHoby}`}>
                                                    <div>
                                                        <label>Vegetarian:</label>
                                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                            <div>
                                                                <button onClick={()=>{setThirdMealRate(true);setForthQuestion(true);
                                                                    setAnswer("0")}}>0
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>{setThirdMealRate(true);setForthQuestion(true);
                                                                    setAnswer("1")}}>1
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>{setThirdMealRate(true);setForthQuestion(true);
                                                                    setAnswer("2")}}>2
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>{setThirdMealRate(true);setForthQuestion(true);
                                                                    setAnswer("3")}}>3
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>{setThirdMealRate(true);setForthQuestion(true);
                                                                    setAnswer("4")}}>4
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {setThirdMealRate(true);setForthQuestion(true);
                                                                    setAnswer("5")}}>5
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div className={`${style.buttons}`}>
                                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => setSecondMealRate(false)}>previous
                                                            </button>
                                                        </div>
                                                    </div>
                                                </div>
                                            )
                                                : (
                                                    <React.Fragment>
                                                        <div className={`mb-3 ${style.question}`}>
                                                            <p>
                                                                Is the weather matters to you?
                                                            </p>
                                                        </div>
                                                        <div className={` ${!props.isMobile ? style.chooseHaveSick : style.chooseHaveSickM} mt-3 ${!props.isMobile ? " ":`row`}`}>
                                                            <div>
                                                                <button onClick={() => {
                                                                    setHaveFoodLife(true);
                                                                    setAnswer(false)
                                                                }}>No</button>
                                                            </div>
                                                            <div>
                                                                <button onClick={() => {
                                                                    setHaveFoodLife(true);
                                                                    setAnswer(true)
                                                                }}>Yes</button>
                                                            </div>
                                                        </div>
                                                    </React.Fragment>
                                                )
                                        }
                                    </React.Fragment>
                                ) : null
                            }
                        </div>
                    </div>
                ) : <MentalHealth isMobile={props.isMobile} personalAnswers={props.personalAnswers} economyAnswer={props.economyAnswer} cultureAnswer={props.cultureAnswer} healthAnswer={healthAnswer}/>
            }
        </React.Fragment>
    )
}
export default HealthQuestion;