import React, {useState} from "react";
import style from "./mentalHealth.module.css";
import EnvironmentQuestions from "../EnvironmentQuestions";

const MentalHealth = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [haveMentalSick, setHaveMentalSick] = useState(false);
    const [mentalProblem, setMentalProblem] = useState([]);

    function checkMentalProblem(event) {

        // setMentalProblem((mentalProblem) => [...mentalProblem, event.target.value])
        setMentalProblem( event.target.value)
        console.log(mentalProblem);
    }

    return (
        <React.Fragment>
            {
                !secondQuestion ?
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        {/*<div className={`${style.questionHeader} mt-3`}>*/}
                        {/*    <h3>*/}
                        {/*        سلامت روانی (۲ سوال)*/}
                        {/*    </h3>*/}
                        {/*    <i className={`${firstQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*    <i className={`${secondQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*</div>*/}
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        {
                                            !haveMentalSick ? (
                                                <React.Fragment>
                                                    <div className={`mb-3 ${style.question}`}>
                                                        <p>
                                                            Do you or any of your family members have a history of mental illness?
                                                        </p>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.haveMentalSick : style.haveMentalSickM} mt-3 ${!props.isMobile  ? " " : `row`}`}>
                                                        <div>
                                                            <button onClick={() => setFirstQuestion(true)}>No</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setHaveMentalSick(true)}>Yes</button>
                                                        </div>
                                                    </div>
                                                </React.Fragment>
                                            ) : (
                                                <React.Fragment>
                                                    <div className={`mb-3 ${style.question}`}>
                                                        <p className={`${style.questionTitle}`}>
                                                            Which one?
                                                        </p>
                                                        <p className={`${style.questionDsc}`}>
                                                            (you can choose more than one)
                                                        </p>
                                                    </div>
                                                    <div className={`${!props.isMobile ? style.chooseMentalSick : style.chooseMentalSickM} ${!props.isMobile ? " ":`row`}`}>
                                                        <label>
                                                            <input type="checkbox" value="افسردگی مینور"
                                                                   onChange={checkMentalProblem}/>
                                                            Minor depression
                                                        </label>
                                                        <label>
                                                            <input type="checkbox" value="افسردگی ماژور"
                                                                   onChange={checkMentalProblem}/>
                                                            Major depression
                                                        </label>
                                                        <label>
                                                            <input type="checkbox" value="اضطراب"
                                                                   onChange={checkMentalProblem}/>
                                                            Anxiety
                                                        </label>
                                                        <label>
                                                            <input type="checkbox" value="وسواس فکری"
                                                                   onChange={checkMentalProblem}/>
                                                            OCD Obsessive Compulsive Disorder
                                                        </label>
                                                        <label>
                                                            Other:
                                                            <input type="text"/>
                                                        </label>
                                                    </div>
                                                    {
                                                        mentalProblem == "" ? (
                                                            <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                <button
                                                                    className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                                </button>
                                                            </div>
                                                        ) : (
                                                            <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                <button
                                                                    className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => setFirstQuestion(true)}>next
                                                                </button>
                                                            </div>
                                                        )
                                                    }
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p>
                                                How much contact do you have with your parents?
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                (You visit your family)
                                            </p>
                                        </div>
                                        <div className={` ${style.chooseMeetingRate} mt-3`}>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    I live with my family and I am very dependent on them
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    I live with my family but I do not depend much on them
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    I go to them almost every day or see each other
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    I see or contact with them 3 to 5 times a week
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    I rarely get in touch with them or see them (3 to 5 times a month)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    We are still a long way from each other (2 to 3 times a year)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    My parents are dead or I do not see them at all / I am not dependent on them at all
                                                </button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setFirstQuestion(false)}>previous
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : null
                            }
                        </div>
                    </div>
                    :
                    <EnvironmentQuestions isMobile={props.isMobile}/>
            }
        </React.Fragment>
    )
}

export default MentalHealth;