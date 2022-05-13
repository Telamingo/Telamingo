import React, {useState} from "react";
import style from "./environmentQuestions.module.css"

const EnvironmentQuestions = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [firstEnvironmentRate, setFirstEnvironmentRate] = useState("");
    const [thirdEnvironmentRate, setThirdEnvironmentRate] = useState("");
    const [forthEnvironmentRate, setForthEnvironmentRate] = useState("");
    const [finalAnswer, setFinalAnswer] = useState([]);
    console.log(forthEnvironmentRate, thirdEnvironmentRate)

    function checkFinalAnswer(event) {

        // setFinalAnswer((mentalProblem) => [...mentalProblem, event.target.value])
        setFinalAnswer(event.target.value)
        console.log(finalAnswer);
    }

    return (
        <React.Fragment>
            {
                !secondQuestion ?
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p>
                                                How compatible are you with any of the following weather conditions?
                                            </p>
                                        </div>
                                        <div className={`mt-3 ${!props.isMobile ? style.environmentHoby:style.environmentHobyM}`}>
                                            <label>Mostly cloudy and rainy</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setFirstEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${!props.isMobile ? style.environmentHoby:style.environmentHobyM}`}>
                                            <label>Mostly snowy </label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setThirdEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${!props.isMobile ? style.environmentHoby:style.environmentHobyM}`}>
                                            <label>Mostly Sunny</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setThirdEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${!props.isMobile ? style.environmentHoby:style.environmentHobyM}`}>
                                            <label>Four seasons and moderate</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setForthEnvironmentRate(event.target.value)}/>
                                        </div>
                                        {
                                            firstEnvironmentRate === "" ?
                                                <div
                                                    className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                    </button>
                                                </div>
                                                :
                                                <div
                                                    className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setFirstQuestion(true)}>next
                                                    </button>
                                                </div>
                                        }
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                Problems with unusual day and night hours (long day or long night)?
                                            </p>
                                        </div>
                                        {
                                            props.isMobile?(
                                                <React.Fragment>
                                                    <div className={`${!props.isMobile?style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>It is not tolerable for me at all</span>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>10</button>
                                                        </div>
                                                    </div>
                                                    <div className={`mb-5 ${!props.isMobile?style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>It does not matter to me</span>
                                                    </div>
                                                </React.Fragment>
                                            ):(
                                                <React.Fragment>
                                                    <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>10</button>
                                                        </div>
                                                    </div>
                                                    <div className={`mb-5 ${!props.isMobile?style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>It is not tolerable for me at all</span>
                                                        <span>It does not matter to me</span>
                                                    </div>
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                                ) : null
                            }
                        </div>
                    </div>
                    :
                    <>
                        {
                            !thirdQuestion ? (
                                <React.Fragment>
                                    <div className={` col-lg-12 ${style.questionBody}`}>
                                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                                            <React.Fragment>
                                                <div className={`mb-3 ${style.question}`}>
                                                    <p>
                                                        In general, what are the two most important challenges of
                                                        immigration in your opinion?
                                                    </p>
                                                    <p className={`${style.questionDsc}`}>
                                                        (Choose two options)
                                                    </p>
                                                </div>
                                                <div
                                                    className={`${!props.isMobile ? style.finalAnswer : style.finalAnswerM}`}>
                                                    <label>
                                                        <input type="checkbox" value=" مسائل مالی و اقتصادی"
                                                               onChange={checkFinalAnswer}/>
                                                        Financial and economic issues
                                                    </label>
                                                    <label>
                                                        <input type="checkbox" value="مسائل شغلی و یا تحصیلی"
                                                               onChange={checkFinalAnswer}/>
                                                        Occupational or educational issues
                                                    </label>
                                                    <label>
                                                        <input type="checkbox" value=" مسائل مربوط به سلامت روحی و جسمی"
                                                               onChange={checkFinalAnswer}/>
                                                        Health issues (mental or physical)
                                                    </label>
                                                    <label>
                                                        <input type="checkbox"
                                                               value="مسائل مربوط به آب و هوا و شرایط اقلیمی"
                                                               onChange={checkFinalAnswer}/>
                                                        Socio-cultural differences
                                                    </label>
                                                    <label>
                                                        <input type="checkbox" value="تفاوت های فرهنگی-اجتماعی"
                                                               onChange={checkFinalAnswer}/>
                                                        Weather and climate issues
                                                    </label>
                                                </div>
                                                {
                                                    finalAnswer === "" ? (
                                                        <div
                                                            className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                            <button
                                                                className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                            </button>
                                                        </div>
                                                    ) : (
                                                        <div
                                                            className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                            <button
                                                                className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                onClick={() => setThirdQuestion(true)}>next
                                                            </button>
                                                        </div>
                                                    )
                                                }
                                            </React.Fragment>
                                        </div>
                                    </div>
                                </React.Fragment>
                            ) : (
                                <React.Fragment>
                                    {
                                        !forthQuestion ? (
                                            <React.Fragment>
                                                <div className={`mt-5 col-lg-12 ${style.questionBody}`}>
                                                    <div className={`mb-3 ${style.question}`}>
                                                        <h3>
                                                            please enter your
                                                            specification below:
                                                        </h3>
                                                        <div className={`${!props.isMobile ? style.information:style.informationM} mt-3 mb-3`}>
                                                            <label htmlFor="name">name: </label>
                                                            <input id="name" name="name" required/><br/>
                                                        </div>
                                                        <div className={`${!props.isMobile ? style.information:style.informationM} mt-3 mb-3`}>
                                                            <label htmlFor="email">email: </label>
                                                            <input type="email" id="email" name="email" required/>
                                                        </div>
                                                        <div className={`${!props.isMobile ? style.information:style.informationM} mt-3 mb-3`}>
                                                            <label htmlFor="email">phone number: </label>
                                                            <input type="number" id="email" name="email" required/>
                                                        </div>
                                                        <div>
                                                            <input className={style.saveButton} type="submit"
                                                                   value="save" onClick={() => setForthQuestion(true)}/>
                                                        </div>
                                                    </div>
                                                </div>
                                            </React.Fragment>
                                        ) : (
                                            <React.Fragment>
                                                <div className={`mt-5 col-lg-12 ${style.questionBody}`}>
                                                    <div className={`mb-3 ${style.question}`}>
                                                        <h3 className="mb-5 mt-5" style={{color:"green"}}>
                                                            thank you so much, we will email the response for you.
                                                        </h3>
                                                    </div>
                                                </div>
                                            </React.Fragment>
                                        )
                                    }
                                </React.Fragment>
                            )
                        }
                    </>
            }
        </React.Fragment>
    )
}
export default EnvironmentQuestions;