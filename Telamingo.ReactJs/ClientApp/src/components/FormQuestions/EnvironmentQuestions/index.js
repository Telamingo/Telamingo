import React, {useState} from "react";
import style from "./environmentQuestions.module.css"

const EnvironmentQuestions = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [firstEnvironmentRate, setFirstEnvironmentRate] = useState("");
    const [secondEnvironmentRate, setSecondEnvironmentRate] = useState("");
    const [thirdEnvironmentRate, setThirdEnvironmentRate] = useState("");
    const [forthEnvironmentRate, setForthEnvironmentRate] = useState("");
    const [fifthEnvironmentRate, setFifthEnvironmentRate] = useState("");
    const [firstFinalQuestionRate, setFirstFinalQuestionRate] = useState("");
    const [secondFinalQuestionRate, setSecondFinalQuestionRate] = useState("");
    const [thirdFinalQuestionRate, setThirdFinalQuestionRate] = useState("");
    const [forthFinalQuestionRate, setForthFinalQuestionRate] = useState("");
    const [fifthFinalQuestionRate, setFifthFinalQuestionRate] = useState("");
    const [finalAnswer, setFinalAnswer] = useState([]);

    function checkFinalAnswer(event) {

        // setFinalAnswer((mentalProblem) => [...mentalProblem, event.target.value])
        setFinalAnswer( event.target.value)
        console.log(finalAnswer);
    }

    return (
        <React.Fragment>
            {
                !secondQuestion ?
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        {/*<div className={`${style.questionHeader} mt-3`}>*/}
                        {/*    <h3>*/}
                        {/*        محیط زیست (۲ سوال)*/}
                        {/*    </h3>*/}
                        {/*    <i className={`${firstQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*    <i className={`${secondQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*</div>*/}
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p>
                                                How compatible are you with any of the following weather conditions?
                                            </p>
                                        </div>
                                        <div className={`mt-3 ${style.environmentHoby}`}>
                                            <label>Mostly cloudy and rainy</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setFirstEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.environmentHoby}`}>
                                            <label>Mostly snowy </label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setThirdEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.environmentHoby}`}>
                                            <label>Mostly Sunny</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setThirdEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.environmentHoby}`}>
                                            <label>Four seasons and moderate</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setForthEnvironmentRate(event.target.value)}/>
                                        </div>
                                        {
                                            firstEnvironmentRate == "" ?
                                                <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                    </button>
                                                </div>
                                                :
                                                <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
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
                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM} mt-5`}>
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
                                        <div className={`mb-5 ${style.creedRateDsc}`}>
                                            <span>It is not tolerable for me at all</span>
                                            <span>It does not matter to me</span>
                                        </div>
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
                                                        In general, what are the two most important challenges of immigration in your opinion?
                                                    </p>
                                                    <p className={`${style.questionDsc}`}>
                                                        (Choose two options)
                                                    </p>
                                                </div>
                                                <div className={`${!props.isMobile?style.finalAnswer:style.finalAnswerM}`}>
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
                                                        <input type="checkbox" value="مسائل مربوط به آب و هوا و شرایط اقلیمی"
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
                                                    finalAnswer == "" ? (
                                                        <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                            <button
                                                                className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                            </button>
                                                        </div>
                                                    ) : (
                                                        <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
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
                            ):(
                                <React.Fragment>
                                    <div className={` col-lg-12 ${style.questionBody}`}>
                                        <div className={`mb-3 ${style.question}`}>
                                            <h3>
                                                Probably your success in this action :
                                            </h3>
                                            <span>70%</span>
                                        </div>
                                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                                            <div className={`mt-5 ${style.resultDsc}`}>
                                                <p>
                                                    Introduction
                                                </p>
                                                <p>
                                                    According to studies, the decision to immigrate is one of the most difficult decisions a person can face in their lifetime. Regardless of the fact that living in any community different from one's own homeland is always fraught with challenges, choosing the right destination for immigration is of particular importance.
                                                </p>
                                            </div>
                                            <div className={`mt-5 ${style.resultDsc}`}>
                                                <p>
                                                    Economy-Welfare
                                                </p>
                                                <p>
                                                    From an economic point of view, various factors are effective in choosing a country as a destination for migration; Inflation, unemployment and GDP are among the most important of these factors. The results of the analysis based on statistical data, the experiences of people with similar conditions to you, the general economic situation in the UK as well as the labor market conditions related to the medical profession show that your economic situation will not necessarily improve with immigration to the UK.
                                                </p>
                                            </div>
                                            <div className={`mt-5 ${style.resultDsc}`}>
                                                <p>
                                                    Culture and society
                                                </p>
                                                <p>
                                                    The issue of cultural compatibility and the type of social relations of the country of origin and destination, language, the possibility of adhering to traditions and personal values and beliefs, is one of the most important and perhaps the most influential factors affecting the quality of life after migration, sometimes due to emphasis on other issues.
                                                </p>
                                            </div>
                                            <div className={`mt-5 ${style.resultDsc}`}>
                                                <p>
                                                    Physical health
                                                </p>
                                                <p>
                                                    The issue of physical health may vary in importance for healthy and unhealthy people, but in reality enjoying the blessings of physical health is an inevitable necessity for any other activity. The emergence of a complication or disease for humans is always unpleasant to worry if If it happens in a foreign country, the resulting problems will be twofold. Absolute opinion that you will be better or worse in the UK in terms of physical health is impossible or at least very difficult because, given the structure of the health system in the UK, the role of individuals in physical health is much greater than in Iran. In the UK, health is based more on self-care and prevention than treatment.
                                                </p>
                                            </div>
                                            <div className={`mt-5 ${style.resultDsc}`}>
                                                <p>
                                                    Mental health
                                                </p>
                                                <p>
                                                    Nostalgia, loneliness, the need for social support, and other challenges related to being away from family, friends, and the environment in which we grew up are some of the things we will definitely experience as an immigrant. On the other hand, issues due to cultural, environmental, etc. differences, which are described in the relevant section, may affect your mental health. Obviously, being aware of the ups and downs of the road ahead, as well as ways to overcome such problems,
                                                </p>
                                            </div>
                                            <div className={`mt-5 ${style.resultDsc}`}>
                                                <p>
                                                    The environment
                                                </p>
                                                <p>
                                                    The issue of the environment and the climate can have direct and indirect effects on other factors such as the physical, mental and even the culture of a community.
                                                </p>
                                            </div>
                                            <div className={`mt-5 ${style.resultDsc}`}>
                                                <p>
                                                    Education and employment
                                                </p>
                                                <p>
                                                    According to your background in water engineering, it is possible for you to continue your studies in the UK for a doctorate. Your work experience in water and also the need for people with water engineering expertise in 2022 will give you a chance to find work in England shows up.
                                                </p>
                                            </div>
                                            <div className={`mt-5 ${style.resultDsc}`}>
                                                <p>
                                                    Conclusion
                                                </p>
                                                <p>
                                                    We must be realistic! Emigration to a foreign country and living in exile are challenging. Sometimes we have to meet certain challenges, and sometimes we need to keep ourselves and our families away from the challenge. To make big decisions, it is always better to draw on the experiences of people who have already come our way.
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </React.Fragment>
                            )
                        }
                    </>
            }
        </React.Fragment>
    )
}
export default EnvironmentQuestions;