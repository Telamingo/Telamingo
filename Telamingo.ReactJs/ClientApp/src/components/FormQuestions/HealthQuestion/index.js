import React, {useState} from "react";
import style from "./healthQuestion.module.css";
import MentalHealth from "../MentalHealth";

const HealthQuestion = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [haveASick, setHaveASick] = useState(false);
    const [sick, setSick] = useState("");
    const [firstMealRate, setFirstMealRate] = useState(false);
    const [secondMealRate, setSecondMealRate] = useState(false);
    const [thirdMealRate, setThirdMealRate] = useState(false);

    const getSickVal =(e)=>{
        setSick(e.target.value)
    }

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
                                                <button onClick={() => setFirstQuestion(true)}>I rarely see a doctor / I rarely need a doctor
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>I see a doctor for periodic checkups
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>Due to certain diseases, I have to see a doctor regularly
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>
                                                    I usually need a doctor urgently
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>I only go to traditional medicine doctors
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
                                                            <button onClick={() => setSecondQuestion(true)}>No</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setHaveASick(true)}>Yes</button>
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
                                                                <input type="text" id="firstSickVal" onChange={getSickVal}/>
                                                            </div>
                                                            <div className="mb-3">
                                                                <label>Second illness:</label>
                                                                <input type="text"/>
                                                            </div>
                                                            <div className="mb-3">
                                                                <label>Third illness:</label>
                                                                <input type="text"/>
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
                                                            sick === "" ?
                                                                <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                    <button
                                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                                    </button>
                                                                </div>
                                                                :
                                                                <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                    <button
                                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                        onClick={() => setSecondQuestion(true)}>next
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
                                                <button onClick={() => setThirdQuestion(true)}>Over $ 10,000</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Between $ 5,000 and $ 10,000
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Between $ 2,000 and $ 5,000
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Between $ 1,000 and $ 2,000
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Less than $ 1,000
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
                                        <div className={`mb-3 ${style.question}`}>
                                            <p>
                                                Do you follow a certain food lifestyle?(Rate from 1 to 10 below)
                                            </p>
                                        </div>
                                        {
                                            !firstMealRate ? (
                                                <div className={`mt-3 mb-5 ${!props.isMobile?style.mealHoby:style.mealHobyM}`}>
                                                    <div>
                                                        <label>Traditional dishes of my country:</label>
                                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                            <div>
                                                                <button onClick={()=>setFirstMealRate(true)}>0
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setFirstMealRate(true)}>1
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setFirstMealRate(true)}>2
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setFirstMealRate(true)}>3
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setFirstMealRate(true)}>4
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setFirstMealRate(true)}>5
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
                                                                <button onClick={()=>setSecondMealRate(true)}>0
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setSecondMealRate(true)}>1
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setSecondMealRate(true)}>2
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setSecondMealRate(true)}>3
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setSecondMealRate(true)}>4
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setSecondMealRate(true)}>5
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
                                                                <button onClick={()=>{setThirdMealRate(true);setForthQuestion(true)}}>0
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>{setThirdMealRate(true);setForthQuestion(true)}}>1
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>{setThirdMealRate(true);setForthQuestion(true)}}>2
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>{setThirdMealRate(true);setForthQuestion(true)}}>3
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>{setThirdMealRate(true);setForthQuestion(true)}}>4
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {setThirdMealRate(true);setForthQuestion(true)}}>5
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
                                        }
                                    </React.Fragment>
                                ) : null
                            }
                        </div>
                    </div>
                ) : <MentalHealth isMobile={props.isMobile}/>
            }
        </React.Fragment>
    )
}
export default HealthQuestion;