import React, {useEffect, useState} from "react";
import style from "./mentalHealth.module.css";
import EnvironmentQuestions from "../EnvironmentQuestions";

const MentalHealth = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [haveMentalSick, setHaveMentalSick] = useState(false);
    const [firstMentalProblem, setFirstMentalProblem] = useState("");
    const [secondMentalProblem, setSecondMentalProblem] = useState("");
    const [thirdMentalProblem, setThirdMentalProblem] = useState("");
    const [forthMentalProblem, setForthMentalProblem] = useState("");
    const [fifthMentalProblem, setFifthMentalProblem] = useState("");
    const [mentalHealthAnswer, setMentalHealthAnswer] = useState("");
    const [mentalIllness, setMentalIllness] = useState("");

    const setAnswer=(answer)=>{
        setMentalHealthAnswer([...mentalHealthAnswer,answer])
    }

    console.log(mentalHealthAnswer)

    function firstMentalIllness(event) {

        setFirstMentalProblem( event.target.value)

    }
    function secondMentalIllness(event) {

        setSecondMentalProblem( event.target.value)

    }
    function thirdMentalIllness(event) {

        setThirdMentalProblem( event.target.value)

    }
    function forthMentalIllness(event) {

        setForthMentalProblem( event.target.value)

    }
    function fifthMentalIllness(event) {

        setFifthMentalProblem( event.target.value)

    }

    const combineMentalHealth =()=>{
        setMentalIllness([...mentalIllness,firstMentalProblem,secondMentalProblem,thirdMentalProblem,forthMentalProblem,fifthMentalProblem])
    }

    useEffect(()=>{
        setAnswer(mentalIllness)
    },[mentalIllness])

    console.log(  firstMentalProblem ,secondMentalProblem , thirdMentalProblem , forthMentalProblem , fifthMentalProblem )
    return (
        <React.Fragment>
            {
                !secondQuestion ?
                    <div className={` col-lg-12 ${style.questionBody}`}>
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
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer(false)
                                                            }}>No</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setHaveMentalSick(true);
                                                                setAnswer(true);
                                                            }}>Yes</button>
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
                                                                   onChange={(e)=>firstMentalIllness(e)}/>
                                                            Minor depression
                                                        </label>
                                                        <label>
                                                            <input type="checkbox" value="افسردگی ماژور"
                                                                   onChange={(e)=>secondMentalIllness(e)}/>
                                                            Major depression
                                                        </label>
                                                        <label>
                                                            <input type="checkbox" value="اضطراب"
                                                                   onChange={(e)=>thirdMentalIllness(e)}/>
                                                            Anxiety
                                                        </label>
                                                        <label>
                                                            <input type="checkbox" value="وسواس فکری"
                                                                   onChange={(e)=>forthMentalIllness(e)}/>
                                                            OCD Obsessive Compulsive Disorder
                                                        </label>
                                                        <label>
                                                            Other:
                                                            <input type="text" className={style.otherMentalIllness} onChange={(e)=>fifthMentalIllness(e)}/>
                                                        </label>
                                                    </div>
                                                    {
                                                        firstMentalProblem || secondMentalProblem || thirdMentalProblem || forthMentalProblem || fifthMentalProblem !== "" ? (
                                                            <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                <button
                                                                    className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => {
                                                                        setFirstQuestion(true);
                                                                        combineMentalHealth()
                                                                    }}>next
                                                                </button>
                                                            </div>

                                                        ) : (
                                                            <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                <button
                                                                    className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
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
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer(" I live with my family and I am very dependent on them")
                                                }}>
                                                    I live with my family and I am very dependent on them
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer("I live with my family but I do not depend much on them")
                                                }}>
                                                    I live with my family but I do not depend much on them
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer("I go to them almost every day or see each other")
                                                }}>
                                                    I go to them almost every day or see each other
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer("I see or contact with them 3 to 5 times a week")
                                                }}>
                                                    I see or contact with them 3 to 5 times a week
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer(" I rarely get in touch with them or see them (3 to 5 times a month)")
                                                }}>
                                                    I rarely get in touch with them or see them (3 to 5 times a month)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer(" We are still a long way from each other (2 to 3 times a year)")
                                                }}>
                                                    We are still a long way from each other (2 to 3 times a year)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer(" My parents are dead or I do not see them at all / I am not dependent on them at all")
                                                }}>
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
                    <EnvironmentQuestions isMobile={props.isMobile} personalAnswers={props.personalAnswers} economyAnswer={props.economyAnswer} cultureAnswer={props.cultureAnswer} healthAnswer={props.healthAnswer} mentalHealthAnswer={mentalHealthAnswer}/>
            }
        </React.Fragment>
    )
}

export default MentalHealth;