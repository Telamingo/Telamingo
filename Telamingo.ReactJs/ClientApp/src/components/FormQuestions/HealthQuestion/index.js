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
    const [firstMealRate, setFirstMealRate] = useState("");
    const [secondMealRate, setSecondMealRate] = useState("");
    const [thirdMealRate, setThirdMealRate] = useState("");
    // const [forthMealRate, setForthMealRate] = useState("");
    // const [fifthMealRate, setFifthMealRate] = useState("");

    const sicks = [
        "sick a", "sick b", "sick c"
    ]
    console.log(secondMealRate,thirdMealRate)
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
                                                        <select value={sick}
                                                                onChange={(event) => setSick(event.target.value)} required>
                                                            <option value="انتخاب کشوراول" selected>choose your illness
                                                            </option>
                                                            {
                                                                sicks.map(item => <option value={item}>{item}</option>)
                                                            }
                                                        </select>
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
                                        <div className={`mt-3 ${!props.isMobile?style.mealHoby:style.mealHobyM}`}>
                                            <label>Traditional dishes of my country</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setFirstMealRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.mealHoby}`}>
                                            <label>Fast Food</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setSecondMealRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.mealHoby}`}>
                                            <label>Vegetarian</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setThirdMealRate(event.target.value)}/>
                                        </div>
                                        <div className={`${style.buttons}`}>
                                            <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setThirdQuestion(false)}>previous
                                                </button>
                                            </div>
                                            {
                                                firstMealRate === "" ?
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