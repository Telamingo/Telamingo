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

        setFinalAnswer((mentalProblem) => [...mentalProblem, event.target.value])
        console.log(finalAnswer);
    }

    return (
        <React.Fragment>
            {
                !secondQuestion ?
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        <div className={`${style.questionHeader} mt-3`}>
                            <h3>
                                محیط زیست (۲ سوال)
                            </h3>
                            <i className={`${firstQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${secondQuestion ? style.active : style.deActive}`}> </i>
                        </div>
                        <div className={`${style.questionContent} mt-5`} dir='rtl'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div>
                                            <p className={`${style.questionTitle}`}>
                                                میزان سازگاری شما با هر یک از شرایط آب و هوایی زیر چگونه است؟
                                            </p>
                                        </div>
                                        <div className={`mt-3 ${style.environmentHoby}`}>
                                            <label>اغلب ابری و بارانی (1 تا 10)</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={() => setFirstEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.environmentHoby}`}>
                                            <label>اغلب برفی (1 تا 10)</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={() => setThirdEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.environmentHoby}`}>
                                            <label>اغلب آفتابی (1 تا 10)</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={() => setThirdEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.environmentHoby}`}>
                                            <label>چهار فصل و معتدل (1 تا 10)</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={() => setForthEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.environmentHoby}`}>
                                            <label>
                                                برایم فرقی نمیکند
                                            </label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={() => setFifthEnvironmentRate(event.target.value)}/>
                                        </div>
                                        {
                                            firstEnvironmentRate == "" ?
                                                <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                                :
                                                <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setFirstQuestion(true)}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                        }
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div>
                                            <p className={`${style.questionTitle}`}>
                                                میزان سازگاری شما با هر یک از شرایط اقلیمی زیر چگونه است؟
                                            </p>
                                        </div>
                                        <div className={`mt-3 ${!props.isMobile ? style.environmentHoby : style.environmentHobyM}`}>
                                            <label>ساعات کم روز (شب های طولانی) (1 تا 10) </label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={() => setFirstEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${!props.isMobile ? style.environmentHoby : style.environmentHobyM}`}>
                                            <label>ساعات کم شب (روزهای طولانی) (1 تا 10)</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={() => setThirdEnvironmentRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${!props.isMobile ? style.environmentHoby : style.environmentHobyM}`}>
                                            <label>برایم فرقی نمیکند</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={() => setThirdEnvironmentRate(event.target.value)}/>
                                        </div>
                                        {
                                            firstEnvironmentRate == "" ?
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                                :
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setSecondQuestion(true)}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                        }
                                        <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setFirstQuestion(false)}>سوال قبلی
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : null
                            }
                        </div>
                    </div>
                    :
                    <>
                        {
                            !forthQuestion ?
                                <React.Fragment>
                                    <div className={` col-lg-12 ${style.questionBody}`}>
                                        <div className={`${style.questionHeader} mt-3`}>
                                            <h3>
                                                :دو سوال انتهایی پرسشنامه
                                            </h3>
                                        </div>
                                        <div className={`${style.questionContent} mt-5`} dir='rtl'>
                                            {
                                                !thirdQuestion ? (
                                                        <React.Fragment>
                                                            <div>
                                                                <p className={`${style.questionTitle}`}>
                                                                    به طور کلی به نظر شما هر یک از موارد زیر چقدر در زمینه مهاجرت شما حائز اهمیت است:
                                                                </p>
                                                            </div>
                                                            <div className={`mt-3 ${!props.isMobile ? style.environmentHoby : style.environmentHobyM}`}>
                                                                <label>مسائل مالی و اقتصادی (1 تا 10)</label>
                                                                <input type="number" min="1" max="10" step="1"
                                                                       onChange={() => setFirstFinalQuestionRate(event.target.value)}/>
                                                            </div>
                                                            <div className={`mt-3 ${!props.isMobile ? style.environmentHoby : style.environmentHobyM}`}>
                                                                <label>مسائل شغلی و یا تحصیلی (1 تا 10)</label>
                                                                <input type="number" min="1" max="10" step="1"
                                                                       onChange={() => setSecondFinalQuestionRate(event.target.value)}/>
                                                            </div>
                                                            <div className={`mt-3 ${!props.isMobile ? style.environmentHoby : style.environmentHobyM}`}>
                                                                <label>مسائل مربوط به سلامت روحی و جسمی (1 تا 10)</label>
                                                                <input type="number" min="1" max="10" step="1"
                                                                       onChange={() => setThirdFinalQuestionRate(event.target.value)}/>
                                                            </div>
                                                            <div className={`mt-3 ${!props.isMobile ? style.environmentHoby : style.environmentHobyM}`}>
                                                                <label>مسائل مربوط به آب و هوا و شرایط اقلیمی (1 تا 10)</label>
                                                                <input type="number" min="1" max="10" step="1"
                                                                       onChange={() => setForthFinalQuestionRate(event.target.value)}/>
                                                            </div>
                                                            <div className={`mt-3 ${!props.isMobile ? style.environmentHoby : style.environmentHobyM}`}>
                                                                <label>تفاوت های فرهنگی-اجتماعی (1 تا 10)</label>
                                                                <input type="number" min="1" max="10" step="1"
                                                                       onChange={() => setFifthFinalQuestionRate(event.target.value)}/>
                                                            </div>
                                                            {
                                                                firstFinalQuestionRate == "" ?
                                                                    <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                                        <button
                                                                            className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                                            بعدی
                                                                        </button>
                                                                    </div>
                                                                    :
                                                                    <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                                        <button
                                                                            className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                            onClick={() => setThirdQuestion(true)}>سوال
                                                                            بعدی
                                                                        </button>
                                                                    </div>
                                                            }
                                                        </React.Fragment>
                                                    ) :
                                                    !forthQuestion ? (
                                                        <React.Fragment>
                                                            <div>
                                                                <p className={`${style.questionTitle}`}>
                                                                    به طور کلی دوتا از مهم ترین چالش های مهاجرت از نظر شما چیست؟
                                                                </p>
                                                                <p className={`${style.questionDsc}`}>
                                                                    (انتخاب دو گزینه)
                                                                </p>
                                                            </div>
                                                            <div className={`${!props.isMobile?style.finalAnswer:style.finalAnswerM}`}>
                                                                <label>
                                                                    <input type="checkbox" value=" مسائل مالی و اقتصادی"
                                                                           onChange={checkFinalAnswer}/>
                                                                    مسائل مالی و اقتصادی
                                                                </label>
                                                                <label>
                                                                    <input type="checkbox" value="مسائل شغلی و یا تحصیلی"
                                                                           onChange={checkFinalAnswer}/>
                                                                    مسائل شغلی و یا تحصیلی
                                                                </label>
                                                                <label>
                                                                    <input type="checkbox" value=" مسائل مربوط به سلامت روحی و جسمی"
                                                                           onChange={checkFinalAnswer}/>
                                                                    مسائل مربوط به سلامت روحی و جسمی
                                                                </label>
                                                                <label>
                                                                    <input type="checkbox" value="مسائل مربوط به آب و هوا و شرایط اقلیمی"
                                                                           onChange={checkFinalAnswer}/>
                                                                    مسائل مربوط به آب و هوا و شرایط اقلیمی
                                                                </label>
                                                                <label>
                                                                    <input type="checkbox" value="تفاوت های فرهنگی-اجتماعی"
                                                                           onChange={checkFinalAnswer}/>
                                                                    تفاوت های فرهنگی-اجتماعی
                                                                </label>
                                                            </div>
                                                            {
                                                                finalAnswer == "" ? (
                                                                    <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                                        <button
                                                                            className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                                            بعدی
                                                                        </button>
                                                                    </div>
                                                                ) : (
                                                                    <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                                        <button
                                                                            className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                            onClick={() => setForthQuestion(true)}>سوال
                                                                            بعدی
                                                                        </button>
                                                                    </div>
                                                                )
                                                            }
                                                        </React.Fragment>
                                                    ) : null
                                            }
                                        </div>
                                    </div>
                                </React.Fragment>
                                :
                                <React.Fragment>
                                    <div className={` col-lg-12 ${style.questionBody}`}>
                                        <div className={`${style.FinalHeader} mt-3`}>
                                            <h3>
                                                :احتمالا موفقیت شما در این اقدام
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
                        }
                    </>
            }
        </React.Fragment>
    )
}
export default EnvironmentQuestions;