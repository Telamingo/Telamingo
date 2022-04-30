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
                                                        onClick={() => setSecondQuestion(true)}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                        }
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
                                <>
                                    <h1>
                                        end
                                    </h1>
                                </>
                        }
                    </>
            }
        </React.Fragment>
    )
}
export default EnvironmentQuestions;